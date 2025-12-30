using System;

namespace PingChaText0
{
    /// <summary>
    /// Represents a mathematical matrix.
    /// </summary>
    public class Matrix
    {
        private double[,] _data;
        private int _rows;
        private int _cols;
        private string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class.
        /// </summary>
        /// <param name="rows">The number of rows.</param>
        /// <param name="cols">The number of columns.</param>
        public Matrix(int rows, int cols)
        {
            _rows = rows;
            _cols = cols;
            _data = new double[_rows, _cols];
            _name = "Result";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class with a name.
        /// </summary>
        /// <param name="rows">The number of rows.</param>
        /// <param name="cols">The number of columns.</param>
        /// <param name="name">The name of the matrix.</param>
        public Matrix(int rows, int cols, string name)
        {
            _rows = rows;
            _cols = cols;
            _data = new double[_rows, _cols];
            _name = name;
        }

        /// <summary>
        /// Gets the number of rows.
        /// </summary>
        public int Rows
        {
            get { return _rows; }
        }

        /// <summary>
        /// Gets the number of columns.
        /// </summary>
        public int Cols
        {
            get { return _cols; }
        }

        /// <summary>
        /// Gets or sets the data of the matrix.
        /// </summary>
        public double[,] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        /// <summary>
        /// Gets or sets the name of the matrix.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
