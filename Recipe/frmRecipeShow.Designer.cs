namespace Recipe
{
    partial class frmRecipeShow
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
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).BeginInit();
            SuspendLayout();
            // 
            // dgvRecipes
            // 
            dgvRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipes.Location = new Point(55, 56);
            dgvRecipes.Name = "dgvRecipes";
            dgvRecipes.Size = new Size(535, 331);
            dgvRecipes.TabIndex = 0;
            // 
            // frmRecipeShow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRecipes);
            Name = "frmRecipeShow";
            Text = "frmRecipeShow";
            Load += frmRecipeShow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecipes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRecipes;
    }
}