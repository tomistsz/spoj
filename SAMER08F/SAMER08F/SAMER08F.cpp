// SAMER08F - Feynman
// https://www.spoj.com/problems/SAMER08F/

#include "pch.h" // not needed on SPOJ
#include <iostream>

using namespace std;

int main()
{
	int result;
	int n;
	cin >> n;

	while (n != 0)
	{
		result = 0;
		for (int i = 1; i <= n; i++)
		{
			result = result + i * i;
		}
		cout << result << endl;
		
		cin >> n;
	}
	
}
