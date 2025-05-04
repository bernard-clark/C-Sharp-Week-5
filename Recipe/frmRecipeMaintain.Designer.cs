namespace Recipe
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtCategory = new TextBox();
            numPrepTime = new NumericUpDown();
            txtIngredients = new TextBox();
            txtSubmittedBy = new TextBox();
            lbRecipes = new ListBox();
            btnAddRecipe = new Button();
            dgvShow = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numPrepTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShow).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(32, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(32, 67);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 1;
            // 
            // numPrepTime
            // 
            numPrepTime.Location = new Point(21, 106);
            numPrepTime.Name = "numPrepTime";
            numPrepTime.Size = new Size(120, 23);
            numPrepTime.TabIndex = 2;
            // 
            // txtIngredients
            // 
            txtIngredients.Location = new Point(32, 145);
            txtIngredients.Name = "txtIngredients";
            txtIngredients.Size = new Size(100, 23);
            txtIngredients.TabIndex = 3;
            // 
            // txtSubmittedBy
            // 
            txtSubmittedBy.Location = new Point(32, 183);
            txtSubmittedBy.Name = "txtSubmittedBy";
            txtSubmittedBy.Size = new Size(100, 23);
            txtSubmittedBy.TabIndex = 5;
            // 
            // lbRecipes
            // 
            lbRecipes.FormattingEnabled = true;
            lbRecipes.ItemHeight = 15;
            lbRecipes.Location = new Point(206, 30);
            lbRecipes.Name = "lbRecipes";
            lbRecipes.Size = new Size(546, 214);
            lbRecipes.TabIndex = 7;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.BackColor = SystemColors.ButtonHighlight;
            btnAddRecipe.Location = new Point(45, 221);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(75, 23);
            btnAddRecipe.TabIndex = 8;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = false;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // dgvShow
            // 
            dgvShow.BackgroundColor = SystemColors.ButtonHighlight;
            dgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShow.Location = new Point(59, 266);
            dgvShow.Name = "dgvShow";
            dgvShow.Size = new Size(650, 159);
            dgvShow.TabIndex = 9;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvShow);
            Controls.Add(btnAddRecipe);
            Controls.Add(lbRecipes);
            Controls.Add(txtSubmittedBy);
            Controls.Add(txtIngredients);
            Controls.Add(numPrepTime);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Name = "form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPrepTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtCategory;
        private NumericUpDown numPrepTime;
        private TextBox txtIngredients;
        private TextBox txtSubmittedBy;
        private ListBox lbRecipes;
        private Button btnAddRecipe;
        private DataGridView dgvShow;
    }
}
