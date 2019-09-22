using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Calculator
{
    public partial class FormCalculator : Form
    {
        public Matrix A, B, C;
        public TextBox[,] BoxA;
        public TextBox[,] BoxB;
        public TextBox[,] BoxC; //Box C is the solution matrix

        public FormCalculator()
        {
            InitializeComponent();
            lblMatrixC.Hide();
        }

        public class Matrix
        {
            public double[,] Cells;
            public int Row;
            public int Col;

            public Matrix(int nRow, int nCol)
            {
                Cells = new double[nRow, nCol];
                Row = nRow;
                Col = nCol;
            }

            public Matrix Add(Matrix other)
            {
                Matrix Solution = new Matrix(Row, Col); //Creates a temperorary matrix 
                for (int i = 0; i < Col; i++)
                {
                    for (int j = 0; j < Row; j++)
                    {
                        Solution.Cells[j, i] = this.Cells[j, i] + other.Cells[j, i];
                    }
                }
                return Solution;
            }

            public Matrix Subtract(Matrix other)
            {
                Matrix Solution = new Matrix(Row, Col);
                for (int i = 0; i < Col; i++)
                {
                    for (int j = 0; j < Row; j++)
                    {
                        Solution.Cells[j, i] = this.Cells[j, i] - other.Cells[j, i];
                    }
                }
                return Solution;
            }

            public Matrix Multiply(Matrix other)
            {
                Matrix Solution = new Matrix(Row, other.Col);
                for (int i = 0; i < this.Row; i++)
                {
                    for (int j = 0; j < other.Col; j++)
                    {
                        for (int k = 0; k < this.Col; k++)
                        {
                            Solution.Cells[i, j] = Solution.Cells[i, j] + this.Cells[i, k] * other.Cells[k, j];
                            //Multiplication of the two cells is the dot product and to get the solution cell's answer,
                            //it must add itself to it as the final result is the sum of each individual dot product.
                        }
                    }
                }
                return Solution;
            }

            //Recursive method to calculate determinant of a matrix, orignial source code citations below:
            /***************************************************************************************
            *    Title: <Matrix Determinant>
            *    Author: <Mandar Sadye>
            *    Date: < Oct 3 '17 at 14:08>
            *    Code version: <N/A>
            *    Availability: <https://stackoverflow.com/questions/46545044/determinant-of-matrix-with-recursion>
            *
            ***************************************************************************************/
            public double Determinant(Matrix D, int n) //n will be the dimensions of the matrix and D is any arbitrary matrix
            {
                double d = 0; //d will be the determinant value

                if (n == 1)
                {
                    return D.Cells[0, 0];
                }
                else if (n == 2) //2 x 2 determinant formula
                {
                    d = (D.Cells[0, 0] * D.Cells[1, 1]) - (D.Cells[1, 0] * D.Cells[0, 1]);
                    return d;
                }
                else
                {
                    Matrix Short = new Matrix(n - 1, n - 1); //Creates a smaller matrix 
                    for (int i = 0; i < n; i++) //Columns
                    {
                        for (int j = 0; j < n - 1; j++) //Rows
                        {
                            int counter = 0; //Counter is used for the index of the smaller matrix
                            for (int k = 0; k < n; k++)
                            {
                                if (k == i)
                                {
                                    continue;
                                    /*Continue will skip this iteration of the loop.
                                    This will skip the column of the larger matrix. Doing this will make sure the 
                                    element in that column will be multiplied only by the remaining columns
                                    */
                                }

                                Short.Cells[j, counter] = D.Cells[j + 1, k]; //Assigns the values of the larger matrix to the smaller one
                                counter++;
                            }
                        }
                        double c = D.Cells[0, i] * Determinant(Short, n - 1); //Keeps on passing matrices until it is a 2 by 2 matrix
                        d += Math.Pow(-1, i) * c; //Sign change according to how many matrices there are
                    }
                    return d;
                }
            }
        }

        public void Remove(TextBox[,] Cell) //Removes the dynamically created textboxes 
        {
            for (int i = 0; i < Cell.GetLength(1); i++) //GetLength(1) = Col
            {
                for (int j = 0; j < Cell.GetLength(0); j++)
                {
                    this.Controls.Remove(Cell[j, i]);
                }
            }
        }

        public void Clear(TextBox[,] Cell) //Clears the entries of the matrix
        {
            for (int i = 0; i < Cell.GetLength(1); i++)
            {
                for (int j = 0; j < Cell.GetLength(0); j++)
                {
                    Cell[j, i].Text = "";
                }
            }
        }

        public void Create(TextBox[,] Cell, int xCoord) //Creates the textboxes on screen
        {
            for (int i = 0; i < Cell.GetLength(1); i++)
            {
                for (int j = 0; j < Cell.GetLength(0); j++)
                {
                    TextBox Celln = new TextBox();
                    Celln.Name = "Celln" + j.ToString() + "," + i.ToString(); //Naming convention is row, column
                    Celln.AutoSize = false;
                    Celln.Size = new System.Drawing.Size(50, 22);
                    Celln.Location = new Point(xCoord + (i * 50), 75 + (j * 25));
                    this.Controls.Add(Celln);
                    Cell[j, i] = Celln;
                }
            }
        }

        public Matrix Save(TextBox[,] Cell) //Saves the entries of each textbox/cell 
        {
            Matrix Save = new Matrix(Cell.GetLength(0), Cell.GetLength(1)); //Temperorary Matrix 

            for (int i = 0; i < Cell.GetLength(1); i++)
            {
                for (int j = 0; j < Cell.GetLength(0); j++)
                {
                    if (Cell[j, i].Text == "") //If text is blank, the value for that cell is zero
                    {
                        Save.Cells[j, i] = 0;
                    }
                    else
                    {
                        Save.Cells[j, i] = Convert.ToDouble(Cell[j, i].Text);
                    }
                }
            }
            return Save;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxC != null)
                {
                    Remove(BoxC); //Removes the previous matrix
                }

                A = Save(BoxA);
                B = Save(BoxB);

                if ((A.Row != B.Row) || (A.Col != B.Col)) //Matrices must be the same size
                {
                    MessageBox.Show("Matrices are not the same size!");
                    lblMatrixC.Hide();
                    return;
                }

                BoxC = new TextBox[A.Row, A.Col]; //Matrix C has the same dimensions

                //Generates the cells for matrix C
                Create(BoxC, 575);
                C = A.Add(B);

                for (int i = 0; i < BoxC.GetLength(1); i++)
                {
                    for (int j = 0; j < BoxC.GetLength(0); j++)
                    {
                        BoxC[j, i].Text = C.Cells[j, i].ToString();
                    }
                }
                lblMatrixC.Show();
            }
            catch
            {
                MessageBox.Show("Input Error!");
                return;
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxC != null)
                {
                    Remove(BoxC);
                }

                A = Save(BoxA);
                B = Save(BoxB);

                if ((A.Row != B.Row) || (A.Col != B.Col))
                {
                    MessageBox.Show("Matrices are not the same size!");
                    lblMatrixC.Hide();
                    return;
                }

                BoxC = new TextBox[A.Row, A.Col]; //Matrix C has the same dimensions

                //Generates the cells for matrix C
                Create(BoxC, 575);
                C = A.Subtract(B);

                for (int i = 0; i < BoxC.GetLength(1); i++)
                {
                    for (int j = 0; j < BoxC.GetLength(0); j++)
                    {
                        BoxC[j, i].Text = C.Cells[j, i].ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Input Error!");
                return;
            }
            lblMatrixC.Show();
        }

        private void BtnClearA_Click(object sender, EventArgs e)
        {
            try
            {
                Clear(BoxA);
            }
            catch
            {
                MessageBox.Show("Input Error!");
                return;
            }
            
        }

        private void BtnClearB_Click(object sender, EventArgs e)
        {
            try
            {
                Clear(BoxB);
            }
            catch
            {
                MessageBox.Show("Input Error!");
                return;
            }
        }

        private void BtnDetA_Click(object sender, EventArgs e)
        {
            try
            {
                if (numRow1.Value != numCol1.Value)
                {
                    MessageBox.Show("Rows and Columns must be the same size!");
                    return;
                }

                A = Save(BoxA);
                double Det;
                Det = A.Determinant(A, BoxA.GetLength(0));
                MessageBox.Show(Det.ToString());
            }
            catch
            {
                MessageBox.Show("Input Error!");
                return;
            }
        }

        private void BtnDetB_Click(object sender, EventArgs e)
        {
            try
            {
                if (numRow2.Value != numCol2.Value)
                {
                    MessageBox.Show("Rows and Columns must be the same size!");
                    return;
                }
                B = Save(BoxB);
                double Det;
                Det = B.Determinant(B, BoxB.GetLength(0));
                MessageBox.Show(Det.ToString());
            }
            catch
            {
                MessageBox.Show("Input Error!");
                return;
            }
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            if (BoxA != null)
            {
                Remove(BoxA); //Removes the previous matrix
            }
            if (BoxB != null)
            {
                Remove(BoxB); //Removes the previous matrix
            }

            int RowA = Convert.ToInt32(numRow1.Text);
            int ColA = Convert.ToInt32(numCol1.Text);
            int RowB = Convert.ToInt32(numRow2.Text);
            int ColB = Convert.ToInt32(numCol2.Text);

            BoxA = new TextBox[RowA, ColA];
            BoxB = new TextBox[RowB, ColB];

            //Creates the Cells for Matrix A and B
            Create(BoxA, 30);
            Create(BoxB, 300);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxC != null)
                {
                    Remove(BoxC);
                }

                A = Save(BoxA);
                B = Save(BoxB);

                if (numCol1.Value != numRow2.Value)
                {
                    MessageBox.Show("Matrix A's Columns must be equal to Matrix B's Rows!");
                    lblMatrixC.Hide();
                    return;
                }

                BoxC = new TextBox[A.Row, B.Col];

                //Generates the cells for matrix C
                Create(BoxC, 575);
                C = A.Multiply(B);

                for (int i = 0; i < BoxC.GetLength(1); i++)
                {
                    for (int j = 0; j < BoxC.GetLength(0); j++)
                    {
                        BoxC[j, i].Text = C.Cells[j, i].ToString();
                    }
                }
                lblMatrixC.Show();
            }
            catch
            {
                MessageBox.Show("Input Error!");
                return;
            }

        }
    }
}
