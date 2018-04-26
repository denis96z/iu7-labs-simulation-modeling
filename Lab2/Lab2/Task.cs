namespace Lab2
{
    class States
    {
        public double[] Solve(double[,] lambda)
        {
            int n = lambda.GetLength(0);
            (double[] dp, double[,] k) = CreateSystem(lambda, n);

            alglib.rmatrixsolve(k, n, dp, out var info, out var rep, out var t);

            for (int i = 0; i < n; i++)
            {
                double s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += lambda[j, i];
                }
                t[i] /= s;
            }

            return t;
        }

        private (double[], double[,]) CreateSystem(double[,] lambda, int n)
        {
            double[] dp = new double[n];
            double[,] k = new double[n, n];

            dp[0] = 1;
            for (int i = 1; i < n; i++)
            {
                dp[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                k[i, i] = 0;
                for (int j = 0; j < i; j++)
                {
                    k[i, i] -= lambda[i, j];
                    k[i, j] = lambda[j, i];
                }

                for (int j = i + 1; j < n; j++)
                {
                    k[i, i] -= lambda[i, j];
                    k[i, j] = lambda[j, i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                k[0, i] = 1;
            }

            return (dp, k);
        }
    }
}
