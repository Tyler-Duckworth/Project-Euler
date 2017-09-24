#include <iostream>

int main(int argc, char *argv[]) {
	int chars = 0;
	for (int i = 0; i < 1000; i++) {
		if ((i % 3 == 0) || (i % 5 == 0)) {
			chars += i;
		}
	}
	std::cout << "The total sum is: " << chars << "\n";
}