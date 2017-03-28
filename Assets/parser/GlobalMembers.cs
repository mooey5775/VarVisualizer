﻿public static class GlobalMembers
{
static int Main()
{
								int b;
								int fibnums = 10;
								b=3;

								fibnums = 10;
								List<int> f;
								List<int> f = new List<int>(fibnums);
								f[0] = 1;
								f[1] = 1;
								for (int i = 2; i < fibnums; i++)
								{
																f[i] += f[i - 2];
																f[i] += f[i - 1];
								}

								return 0;
}
}
