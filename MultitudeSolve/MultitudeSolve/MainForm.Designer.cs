namespace MultitudeSolve
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UniversalCHeck = new System.Windows.Forms.CheckBox();
            this.FirstMultitude = new System.Windows.Forms.TextBox();
            this.SecondMultitude = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.FirstRelation = new System.Windows.Forms.TextBox();
            this.SecondRelation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButCrossing = new System.Windows.Forms.Button();
            this.ButAssociation = new System.Windows.Forms.Button();
            this.ButDifference = new System.Windows.Forms.Button();
            this.ButSymetricDifference = new System.Windows.Forms.Button();
            this.ButCartesianWork = new System.Windows.Forms.Button();
            this.ButAddition = new System.Windows.Forms.Button();
            this.ButComposition = new System.Windows.Forms.Button();
            this.ButAddress = new System.Windows.Forms.Button();
            this.Universal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UniversalCHeck
            // 
            this.UniversalCHeck.AutoSize = true;
            this.UniversalCHeck.Location = new System.Drawing.Point(500, 8);
            this.UniversalCHeck.Name = "UniversalCHeck";
            this.UniversalCHeck.Size = new System.Drawing.Size(109, 17);
            this.UniversalCHeck.TabIndex = 2;
            this.UniversalCHeck.Text = "Задать Universal";
            this.UniversalCHeck.UseVisualStyleBackColor = true;
            this.UniversalCHeck.CheckedChanged += new System.EventHandler(this.UniversalCHeck_CheckedChanged);
            // 
            // FirstMultitude
            // 
            this.FirstMultitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstMultitude.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstMultitude.Location = new System.Drawing.Point(33, 33);
            this.FirstMultitude.Multiline = true;
            this.FirstMultitude.Name = "FirstMultitude";
            this.FirstMultitude.Size = new System.Drawing.Size(139, 32);
            this.FirstMultitude.TabIndex = 4;
            // 
            // SecondMultitude
            // 
            this.SecondMultitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondMultitude.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondMultitude.Location = new System.Drawing.Point(33, 90);
            this.SecondMultitude.Multiline = true;
            this.SecondMultitude.Name = "SecondMultitude";
            this.SecondMultitude.Size = new System.Drawing.Size(139, 27);
            this.SecondMultitude.TabIndex = 5;
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(12, 183);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result.Size = new System.Drawing.Size(368, 139);
            this.Result.TabIndex = 6;
            // 
            // FirstRelation
            // 
            this.FirstRelation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstRelation.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstRelation.Location = new System.Drawing.Point(267, 33);
            this.FirstRelation.Multiline = true;
            this.FirstRelation.Name = "FirstRelation";
            this.FirstRelation.Size = new System.Drawing.Size(183, 32);
            this.FirstRelation.TabIndex = 7;
            // 
            // SecondRelation
            // 
            this.SecondRelation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondRelation.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondRelation.Location = new System.Drawing.Point(267, 87);
            this.SecondRelation.Multiline = true;
            this.SecondRelation.Name = "SecondRelation";
            this.SecondRelation.Size = new System.Drawing.Size(183, 30);
            this.SecondRelation.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Множества";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Бинарные отношения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Результат";
            // 
            // ButCrossing
            // 
            this.ButCrossing.Location = new System.Drawing.Point(508, 142);
            this.ButCrossing.Name = "ButCrossing";
            this.ButCrossing.Size = new System.Drawing.Size(113, 23);
            this.ButCrossing.TabIndex = 13;
            this.ButCrossing.Text = "Пересечение";
            this.ButCrossing.UseVisualStyleBackColor = true;
            // 
            // ButAssociation
            // 
            this.ButAssociation.Location = new System.Drawing.Point(508, 181);
            this.ButAssociation.Name = "ButAssociation";
            this.ButAssociation.Size = new System.Drawing.Size(113, 23);
            this.ButAssociation.TabIndex = 14;
            this.ButAssociation.Text = "Объединение";
            this.ButAssociation.UseVisualStyleBackColor = true;
            // 
            // ButDifference
            // 
            this.ButDifference.Location = new System.Drawing.Point(508, 221);
            this.ButDifference.Name = "ButDifference";
            this.ButDifference.Size = new System.Drawing.Size(113, 23);
            this.ButDifference.TabIndex = 15;
            this.ButDifference.Text = "Разность";
            this.ButDifference.UseVisualStyleBackColor = true;
            // 
            // ButSymetricDifference
            // 
            this.ButSymetricDifference.Location = new System.Drawing.Point(508, 250);
            this.ButSymetricDifference.Name = "ButSymetricDifference";
            this.ButSymetricDifference.Size = new System.Drawing.Size(113, 23);
            this.ButSymetricDifference.TabIndex = 16;
            this.ButSymetricDifference.Text = "Симметр.Разность";
            this.ButSymetricDifference.UseVisualStyleBackColor = true;
            // 
            // ButCartesianWork
            // 
            this.ButCartesianWork.Location = new System.Drawing.Point(508, 288);
            this.ButCartesianWork.Name = "ButCartesianWork";
            this.ButCartesianWork.Size = new System.Drawing.Size(113, 23);
            this.ButCartesianWork.TabIndex = 17;
            this.ButCartesianWork.Text = "Дек-го Произ-е";
            this.ButCartesianWork.UseVisualStyleBackColor = true;
            // 
            // ButAddition
            // 
            this.ButAddition.Location = new System.Drawing.Point(508, 327);
            this.ButAddition.Name = "ButAddition";
            this.ButAddition.Size = new System.Drawing.Size(113, 23);
            this.ButAddition.TabIndex = 18;
            this.ButAddition.Text = "Дополнение";
            this.ButAddition.UseVisualStyleBackColor = true;
            // 
            // ButComposition
            // 
            this.ButComposition.Location = new System.Drawing.Point(508, 366);
            this.ButComposition.Name = "ButComposition";
            this.ButComposition.Size = new System.Drawing.Size(113, 23);
            this.ButComposition.TabIndex = 19;
            this.ButComposition.Text = "Композиция";
            this.ButComposition.UseVisualStyleBackColor = true;
            // 
            // ButAddress
            // 
            this.ButAddress.Location = new System.Drawing.Point(508, 404);
            this.ButAddress.Name = "ButAddress";
            this.ButAddress.Size = new System.Drawing.Size(113, 23);
            this.ButAddress.TabIndex = 20;
            this.ButAddress.Text = "Обращение";
            this.ButAddress.UseVisualStyleBackColor = true;
            // 
            // Universal
            // 
            this.Universal.Location = new System.Drawing.Point(496, 54);
            this.Universal.Name = "Universal";
            this.Universal.ReadOnly = true;
            this.Universal.Size = new System.Drawing.Size(100, 20);
            this.Universal.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.Universal);
            this.Controls.Add(this.ButAddress);
            this.Controls.Add(this.ButComposition);
            this.Controls.Add(this.ButAddition);
            this.Controls.Add(this.ButCartesianWork);
            this.Controls.Add(this.ButSymetricDifference);
            this.Controls.Add(this.ButDifference);
            this.Controls.Add(this.ButAssociation);
            this.Controls.Add(this.ButCrossing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondRelation);
            this.Controls.Add(this.FirstRelation);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondMultitude);
            this.Controls.Add(this.FirstMultitude);
            this.Controls.Add(this.UniversalCHeck);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox UniversalCHeck;
        private System.Windows.Forms.TextBox FirstMultitude;
        private System.Windows.Forms.TextBox SecondMultitude;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox FirstRelation;
        private System.Windows.Forms.TextBox SecondRelation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButCrossing;
        private System.Windows.Forms.Button ButAssociation;
        private System.Windows.Forms.Button ButDifference;
        private System.Windows.Forms.Button ButSymetricDifference;
        private System.Windows.Forms.Button ButCartesianWork;
        private System.Windows.Forms.Button ButAddition;
        private System.Windows.Forms.Button ButComposition;
        private System.Windows.Forms.Button ButAddress;
        private System.Windows.Forms.TextBox Universal;
    }
}

