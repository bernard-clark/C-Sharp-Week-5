
namespace Recipe
{
    partial class frmRecipeDate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvRecipes = new DataGridView();
            txtName = new TextBox();
            txtCategory = new TextBox();
            numPrepTime = new NumericUpDown();
            txtIngredients = new TextBox();
            txtSubmittedBy = new TextBox();
            btnAddRecipes = new Button();
            lbRecipes = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrepTime).BeginInit();
            SuspendLayout();
            // 
            // dgvRecipes
            // 
            dgvRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipes.Location = new Point(70, 237);
            dgvRecipes.Name = "dgvRecipes";
            dgvRecipes.Size = new Size(663, 189);
            dgvRecipes.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(29, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(29, 59);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 2;
            // 
            // numPrepTime
            // 
            numPrepTime.Location = new Point(29, 97);
            numPrepTime.Name = "numPrepTime";
            numPrepTime.Size = new Size(120, 23);
            numPrepTime.TabIndex = 3;
            // 
            // txtIngredients
            // 
            txtIngredients.Location = new Point(29, 138);
            txtIngredients.Name = "txtIngredients";
            txtIngredients.Size = new Size(100, 23);
            txtIngredients.TabIndex = 4;
            // 
            // txtSubmittedBy
            // 
            txtSubmittedBy.Location = new Point(29, 182);
            txtSubmittedBy.Name = "txtSubmittedBy";
            txtSubmittedBy.Size = new Size(100, 23);
            txtSubmittedBy.TabIndex = 5;
            // 
            // btnAddRecipes
            // 
            btnAddRecipes.Location = new Point(150, 182);
            btnAddRecipes.Name = "btnAddRecipes";
            btnAddRecipes.Size = new Size(75, 23);
            btnAddRecipes.TabIndex = 6;
            btnAddRecipes.Text = "button1";
            btnAddRecipes.UseVisualStyleBackColor = true;
            btnAddRecipes.Click += btnAddRecipes_Click;
            // 
            // lbRecipes
            // 
            lbRecipes.FormattingEnabled = true;
            lbRecipes.ItemHeight = 15;
            lbRecipes.Location = new Point(248, 21);
            lbRecipes.Name = "lbRecipes";
            lbRecipes.Size = new Size(485, 184);
            lbRecipes.TabIndex = 7;
            // 
            // frmRecipeDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbRecipes);
            Controls.Add(btnAddRecipes);
            Controls.Add(txtSubmittedBy);
            Controls.Add(txtIngredients);
            Controls.Add(numPrepTime);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Controls.Add(dgvRecipes);
            Name = "frmRecipeDate";
            Load += LoadRecipes;
            Text = "frmRecipeDate";
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrepTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        // Designer Generated Code

        #endregion

        private DataGridView dgvRecipes;
        private TextBox txtName;
        private TextBox txtCategory;
        private NumericUpDown numPrepTime;
        private TextBox txtIngredients;
        private TextBox txtSubmittedBy;
        private Button btnAddRecipes;
        private ListBox lbRecipes;
    }
}