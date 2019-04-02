// assessment_generator.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include <time.h>
#include <stdlib.h>
#include <stdio.h> 

#define DEFAULT_NB_OF_WISHES	(3)
#define MAX_WISHES				(15)

int nb_of_persons = -1;
int nb_of_projects = -1;
int nb_of_wishes = DEFAULT_NB_OF_WISHES;

void help(char *exe)
{
	printf("Create a csv file with random wishes\n");
	printf("Usage:\n");
	printf("%s <nb_of_project> <nb_of_person> [<nb_of_wishes(default:3)>]\n", exe);
	printf("Example: for 15 projects and 10 persons\n");
	printf("%s 15 10\n", exe);
}

int main(int argc, char **argv)
{
	if (argc < 3) {
		help(argv[0]);
		return -1;
	}
	nb_of_projects = atoi(argv[1]);
	nb_of_persons = atoi(argv[2]);
	if (nb_of_persons <= 0 || nb_of_projects <= 0) {
		help(argv[0]);
		return -1;
	}
	if (argc > 3) {
		nb_of_wishes = atoi(argv[3]);
	}
	if (nb_of_wishes > MAX_WISHES) {
		printf("Number of wishes exceeds max (%d)\n", MAX_WISHES);
		return -1;
	}
	char file_name[512] = { 0 };
	int seed = time(NULL);
	sprintf_s(file_name, "gen_%d_%d_%d_%d.csv", nb_of_projects, nb_of_persons, nb_of_wishes, seed);
	printf("Generating file with %d projects, %d persons, %d wishes per persons (seed: %d)\n", nb_of_projects, nb_of_persons, nb_of_wishes, seed);
	printf("File: %s\n", file_name);
	FILE *csv_file;
	fopen_s(&csv_file, file_name, "w+");
	if (!csv_file) {
		printf("Error, could not create %s file\n", file_name);
		return -1;
	}
	// Seed random
	srand(seed);
	// keep track of previous wishes to avoid dupplicated ones
	int prev_wishes[MAX_WISHES];
	int curr_wish;
	for (int i = 0; i < nb_of_persons; i++) {
		// reset wishes
		for (int j = 0; j < nb_of_wishes; j++) {
			prev_wishes[j] = -1;
		}
		for (int j = 0; j < nb_of_wishes; j++) {
			curr_wish = -1;
			while (curr_wish < 0) {
				curr_wish = (rand() % nb_of_projects) /*+ 1*/;
				for (int k = 0; k < nb_of_wishes; k++) {
					if (curr_wish == prev_wishes[k]) {
						// dupplicate wish, continue
						curr_wish = -1;
						break;
					}
				}
			}
			
			fprintf_s(csv_file, "%d,", curr_wish);
			prev_wishes[j] = curr_wish;
		}
		fprintf_s(csv_file, "\n");
	}
	fclose(csv_file);

    return 0;
}

