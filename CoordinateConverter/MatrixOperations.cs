using System;

namespace CoordinateConverter
{
    public static class MatrixOperations
    {
        /*********** Matrix Operations ***********/

        /// <summary>
        /// Adds two matrices.
        /// </summary>
        public static Matrix Add(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArgumentException("Matrix dimensions must match for addition.");
            }

            Matrix result = new Matrix(a.Rows, a.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result.Data[i, j] = a.Data[i, j] + b.Data[i, j];
                }
            }
            return result;
        }

        /// <summary>
        /// Subtracts matrix b from matrix a.
        /// </summary>
        public static Matrix Subtract(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
            {
                throw new ArgumentException("Matrix dimensions must match for subtraction.");
            }

            Matrix result = new Matrix(a.Rows, a.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result.Data[i, j] = a.Data[i, j] - b.Data[i, j];
                }
            }
            return result;
        }

        /// <summary>
        /// Multiplies two matrices.
        /// </summary>
        public static Matrix Multiply(Matrix a, Matrix b)
        {
            if (a.Cols != b.Rows)
            {
                throw new ArgumentException("Number of columns in first matrix must match number of rows in second matrix.");
            }

            Matrix result = new Matrix(a.Rows, b.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Cols; j++)
                {
                    result.Data[i, j] = 0;
                    for (int k = 0; k < a.Cols; k++)
                    {
                        result.Data[i, j] += a.Data[i, k] * b.Data[k, j];
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Multiplies a matrix by a scalar.
        /// </summary>
        public static Matrix Multiply(double scalar, Matrix matrix)
        {
            Matrix result = new Matrix(matrix.Rows, matrix.Cols);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    result.Data[i, j] = matrix.Data[i, j] * scalar;
                }
            }
            return result;
        }

        /// <summary>
        /// Transposes a matrix.
        /// </summary>
        public static Matrix Transpose(Matrix matrix)
        {
            Matrix result = new Matrix(matrix.Cols, matrix.Rows);
            for (int i = 0; i < matrix.Cols; i++)
            {
                for (int j = 0; j < matrix.Rows; j++)
                {
                    result.Data[i, j] = matrix.Data[j, i];
                }
            }
            return result;
        }

        /// <summary>
        /// Inverts a matrix using the adjoint method.
        /// </summary>
        public static Matrix Invert(Matrix matrix)
        {
            double det = Determinant(matrix);
            if (Math.Abs(det) < 1e-10) // Check for singularity with tolerance
            {
                throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
            }

            Matrix adjoint = Adjoint(matrix);
            return Multiply(1.0 / det, adjoint);
        }

        /// <summary>
        /// Calculates the algebraic cofactor matrix.
        /// </summary>
        private static Matrix AlgebraicCofactor(Matrix matrix, int rowToRemove, int colToRemove)
        {
            if (matrix.Rows != matrix.Cols)
            {
                throw new ArgumentException("Matrix must be square.");
            }

            int n = matrix.Rows - 1;
            Matrix result = new Matrix(n, n);

            // Fill top-left
            for (int i = 0; i < rowToRemove; i++)
            {
                for (int j = 0; j < colToRemove; j++)
                {
                    result.Data[i, j] = matrix.Data[i, j];
                }
            }

            // Fill bottom-right
            for (int i = rowToRemove; i < n; i++)
            {
                for (int j = colToRemove; j < n; j++)
                {
                    result.Data[i, j] = matrix.Data[i + 1, j + 1];
                }
            }

            // Fill top-right
            for (int i = 0; i < rowToRemove; i++)
            {
                for (int j = colToRemove; j < n; j++)
                {
                    result.Data[i, j] = matrix.Data[i, j + 1];
                }
            }

            // Fill bottom-left
            for (int i = rowToRemove; i < n; i++)
            {
                for (int j = 0; j < colToRemove; j++)
                {
                    result.Data[i, j] = matrix.Data[i + 1, j];
                }
            }

            // Negate the first column if sum of indices is odd.
            // This is part of the specific determinant calculation algorithm used in this project.
            if ((rowToRemove + colToRemove) % 2 != 0)
            {
                 for (int i = 0; i < n; i++)
                    result.Data[i, 0] = -result.Data[i, 0];
            }

            return result;
        }

        /// <summary>
        /// Calculates the determinant of a matrix.
        /// </summary>
        public static double Determinant(Matrix matrix)
        {
            if (matrix.Rows != matrix.Cols)
            {
                throw new ArgumentException("Matrix must be square.");
            }

            if (matrix.Rows == 1) return matrix.Data[0, 0];

            double D = 0;
            // Expansion along the second row (index 1)
            for (int i = 0; i < matrix.Cols; i++)
            {
                D += matrix.Data[1, i] * Determinant(AlgebraicCofactor(matrix, 1, i));
            }
            return D;
        }

        /// <summary>
        /// Calculates the adjoint matrix.
        /// </summary>
        public static Matrix Adjoint(Matrix matrix)
        {
            Matrix result = new Matrix(matrix.Rows, matrix.Cols);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    result.Data[i, j] = Determinant(AlgebraicCofactor(matrix, j, i));
                }
            }

            return result;
        }
    }
}
