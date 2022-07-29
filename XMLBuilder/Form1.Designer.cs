
namespace XMLBuilder
{
    partial class XMLReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMLReader));
            this.importFile = new DevExpress.XtraEditors.SimpleButton();
            this.saveXMLFile = new DevExpress.XtraEditors.SimpleButton();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.subCategory = new System.Windows.Forms.Label();
            this.subCategoryTextBox = new System.Windows.Forms.TextBox();
            this.categoryControl = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture2Button = new DevExpress.XtraEditors.SimpleButton();
            this.subCatPicTextBox = new System.Windows.Forms.TextBox();
            this.categoryPictureTextBox = new System.Windows.Forms.TextBox();
            this.picture1Button = new DevExpress.XtraEditors.SimpleButton();
            this.stepsControl = new DevExpress.XtraEditors.GroupControl();
            this.weightLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.functionGroupBox = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.variable1Name = new DevExpress.XtraEditors.LabelControl();
            this.variable4TextBox = new System.Windows.Forms.TextBox();
            this.variable3TextBox = new System.Windows.Forms.TextBox();
            this.variable2TextBox = new System.Windows.Forms.TextBox();
            this.variable1TextBox = new System.Windows.Forms.TextBox();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.functionLabel = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.videoButton = new DevExpress.XtraEditors.SimpleButton();
            this.videoTextBox = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.picture3Button = new DevExpress.XtraEditors.SimpleButton();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.xmlTreeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.categoryControl)).BeginInit();
            this.categoryControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsControl)).BeginInit();
            this.stepsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.functionGroupBox)).BeginInit();
            this.functionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // importFile
            // 
            this.importFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importFile.Location = new System.Drawing.Point(13, 12);
            this.importFile.Name = "importFile";
            this.importFile.Size = new System.Drawing.Size(103, 28);
            this.importFile.TabIndex = 1;
            this.importFile.Text = "Import File";
            this.importFile.Click += new System.EventHandler(this.importFile_Click);
            // 
            // saveXMLFile
            // 
            this.saveXMLFile.Location = new System.Drawing.Point(913, 747);
            this.saveXMLFile.Name = "saveXMLFile";
            this.saveXMLFile.Size = new System.Drawing.Size(130, 40);
            this.saveXMLFile.TabIndex = 2;
            this.saveXMLFile.Text = "Save XML File";
            this.saveXMLFile.Click += new System.EventHandler(this.saveXMLFile_Click);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(108, 51);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(221, 21);
            this.categoryTextBox.TabIndex = 3;
            this.categoryTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(19, 54);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.Click += new System.EventHandler(this.categoryLabel_Click);
            // 
            // subCategory
            // 
            this.subCategory.AutoSize = true;
            this.subCategory.Location = new System.Drawing.Point(19, 170);
            this.subCategory.Name = "subCategory";
            this.subCategory.Size = new System.Drawing.Size(73, 13);
            this.subCategory.TabIndex = 6;
            this.subCategory.Text = "Sub Category";
            // 
            // subCategoryTextBox
            // 
            this.subCategoryTextBox.Location = new System.Drawing.Point(108, 167);
            this.subCategoryTextBox.Name = "subCategoryTextBox";
            this.subCategoryTextBox.Size = new System.Drawing.Size(221, 21);
            this.subCategoryTextBox.TabIndex = 5;
            // 
            // categoryControl
            // 
            this.categoryControl.Controls.Add(this.label4);
            this.categoryControl.Controls.Add(this.label1);
            this.categoryControl.Controls.Add(this.picture2Button);
            this.categoryControl.Controls.Add(this.categoryLabel);
            this.categoryControl.Controls.Add(this.subCategory);
            this.categoryControl.Controls.Add(this.subCatPicTextBox);
            this.categoryControl.Controls.Add(this.subCategoryTextBox);
            this.categoryControl.Controls.Add(this.categoryTextBox);
            this.categoryControl.Controls.Add(this.categoryPictureTextBox);
            this.categoryControl.Controls.Add(this.picture1Button);
            this.categoryControl.Location = new System.Drawing.Point(336, 46);
            this.categoryControl.Name = "categoryControl";
            this.categoryControl.Size = new System.Drawing.Size(348, 280);
            this.categoryControl.TabIndex = 13;
            this.categoryControl.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "SubCat PicFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Category PicFile";
            // 
            // picture2Button
            // 
            this.picture2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture2Button.Location = new System.Drawing.Point(107, 225);
            this.picture2Button.Name = "picture2Button";
            this.picture2Button.Size = new System.Drawing.Size(41, 21);
            this.picture2Button.TabIndex = 12;
            this.picture2Button.Text = "Files";
            this.picture2Button.Click += new System.EventHandler(this.picture2Button_Click);
            // 
            // subCatPicTextBox
            // 
            this.subCatPicTextBox.Location = new System.Drawing.Point(147, 225);
            this.subCatPicTextBox.Name = "subCatPicTextBox";
            this.subCatPicTextBox.Size = new System.Drawing.Size(181, 21);
            this.subCatPicTextBox.TabIndex = 11;
            this.subCatPicTextBox.TextChanged += new System.EventHandler(this.subCatPicTextBox_TextChanged);
            // 
            // categoryPictureTextBox
            // 
            this.categoryPictureTextBox.Location = new System.Drawing.Point(147, 109);
            this.categoryPictureTextBox.Name = "categoryPictureTextBox";
            this.categoryPictureTextBox.Size = new System.Drawing.Size(181, 21);
            this.categoryPictureTextBox.TabIndex = 8;
            // 
            // picture1Button
            // 
            this.picture1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture1Button.Location = new System.Drawing.Point(107, 109);
            this.picture1Button.Name = "picture1Button";
            this.picture1Button.Size = new System.Drawing.Size(41, 21);
            this.picture1Button.TabIndex = 9;
            this.picture1Button.Text = "Files";
            this.picture1Button.Click += new System.EventHandler(this.picture1Button_Click);
            // 
            // stepsControl
            // 
            this.stepsControl.Controls.Add(this.weightLabel);
            this.stepsControl.Controls.Add(this.typeLabel);
            this.stepsControl.Controls.Add(this.weightTextBox);
            this.stepsControl.Controls.Add(this.titleTextBox);
            this.stepsControl.Controls.Add(this.textLabel);
            this.stepsControl.Controls.Add(this.typeTextBox);
            this.stepsControl.Controls.Add(this.titleLabel);
            this.stepsControl.Controls.Add(this.textTextBox);
            this.stepsControl.Controls.Add(this.stepsLabel);
            this.stepsControl.Location = new System.Drawing.Point(336, 359);
            this.stepsControl.Name = "stepsControl";
            this.stepsControl.Size = new System.Drawing.Size(348, 231);
            this.stepsControl.TabIndex = 14;
            this.stepsControl.Text = "Steps";
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(24, 190);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 26;
            this.weightLabel.Text = "Weight";
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(24, 145);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 24;
            this.typeLabel.Text = "Type";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(107, 186);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(221, 21);
            this.weightTextBox.TabIndex = 23;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(107, 51);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(221, 21);
            this.titleTextBox.TabIndex = 21;
            this.titleTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textLabel
            // 
            this.textLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(24, 100);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(29, 13);
            this.textLabel.TabIndex = 20;
            this.textLabel.Text = "Text";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(107, 141);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(221, 21);
            this.typeTextBox.TabIndex = 19;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(24, 55);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "Title";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(107, 96);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(221, 21);
            this.textTextBox.TabIndex = 17;
            // 
            // stepsLabel
            // 
            this.stepsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.stepsLabel.Location = new System.Drawing.Point(21, -44);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(39, 13);
            this.stepsLabel.TabIndex = 16;
            this.stepsLabel.Text = "Steps";
            // 
            // functionGroupBox
            // 
            this.functionGroupBox.Controls.Add(this.labelControl7);
            this.functionGroupBox.Controls.Add(this.labelControl5);
            this.functionGroupBox.Controls.Add(this.labelControl3);
            this.functionGroupBox.Controls.Add(this.variable1Name);
            this.functionGroupBox.Controls.Add(this.variable4TextBox);
            this.functionGroupBox.Controls.Add(this.variable3TextBox);
            this.functionGroupBox.Controls.Add(this.variable2TextBox);
            this.functionGroupBox.Controls.Add(this.variable1TextBox);
            this.functionGroupBox.Controls.Add(this.functionTextBox);
            this.functionGroupBox.Controls.Add(this.functionLabel);
            this.functionGroupBox.Location = new System.Drawing.Point(715, 46);
            this.functionGroupBox.Name = "functionGroupBox";
            this.functionGroupBox.Size = new System.Drawing.Size(328, 450);
            this.functionGroupBox.TabIndex = 15;
            this.functionGroupBox.Text = "Function";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(27, 401);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 13);
            this.labelControl7.TabIndex = 49;
            this.labelControl7.Text = "Variable Name";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 317);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "Variable Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 233);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Variable Name";
            // 
            // variable1Name
            // 
            this.variable1Name.Location = new System.Drawing.Point(27, 149);
            this.variable1Name.Name = "variable1Name";
            this.variable1Name.Size = new System.Drawing.Size(68, 13);
            this.variable1Name.TabIndex = 43;
            this.variable1Name.Text = "Variable Name";
            // 
            // variable4TextBox
            // 
            this.variable4TextBox.Location = new System.Drawing.Point(101, 397);
            this.variable4TextBox.Name = "variable4TextBox";
            this.variable4TextBox.Size = new System.Drawing.Size(200, 21);
            this.variable4TextBox.TabIndex = 40;
            // 
            // variable3TextBox
            // 
            this.variable3TextBox.Location = new System.Drawing.Point(101, 313);
            this.variable3TextBox.Name = "variable3TextBox";
            this.variable3TextBox.Size = new System.Drawing.Size(200, 21);
            this.variable3TextBox.TabIndex = 37;
            // 
            // variable2TextBox
            // 
            this.variable2TextBox.Location = new System.Drawing.Point(101, 229);
            this.variable2TextBox.Name = "variable2TextBox";
            this.variable2TextBox.Size = new System.Drawing.Size(200, 21);
            this.variable2TextBox.TabIndex = 4;
            // 
            // variable1TextBox
            // 
            this.variable1TextBox.Location = new System.Drawing.Point(101, 145);
            this.variable1TextBox.Name = "variable1TextBox";
            this.variable1TextBox.Size = new System.Drawing.Size(200, 21);
            this.variable1TextBox.TabIndex = 2;
            // 
            // functionTextBox
            // 
            this.functionTextBox.Location = new System.Drawing.Point(101, 61);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(200, 21);
            this.functionTextBox.TabIndex = 1;
            // 
            // functionLabel
            // 
            this.functionLabel.Location = new System.Drawing.Point(27, 65);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(41, 13);
            this.functionLabel.TabIndex = 0;
            this.functionLabel.Text = "Function";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.videoButton);
            this.groupControl1.Controls.Add(this.videoTextBox);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.picture3Button);
            this.groupControl1.Controls.Add(this.pictureTextBox);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(335, 624);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(348, 163);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Media";
            // 
            // videoButton
            // 
            this.videoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoButton.Location = new System.Drawing.Point(108, 117);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(41, 21);
            this.videoButton.TabIndex = 11;
            this.videoButton.Text = "Files";
            this.videoButton.Click += new System.EventHandler(this.videoButton_Click);
            // 
            // videoTextBox
            // 
            this.videoTextBox.Location = new System.Drawing.Point(148, 117);
            this.videoTextBox.Name = "videoTextBox";
            this.videoTextBox.Size = new System.Drawing.Size(181, 21);
            this.videoTextBox.TabIndex = 10;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(29, 121);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(26, 13);
            this.labelControl11.TabIndex = 9;
            this.labelControl11.Text = "Video";
            // 
            // picture3Button
            // 
            this.picture3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture3Button.Location = new System.Drawing.Point(108, 61);
            this.picture3Button.Name = "picture3Button";
            this.picture3Button.Size = new System.Drawing.Size(41, 21);
            this.picture3Button.TabIndex = 8;
            this.picture3Button.Text = "Files";
            this.picture3Button.Click += new System.EventHandler(this.picture3Button_Click);
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.Location = new System.Drawing.Point(148, 61);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(181, 21);
            this.pictureTextBox.TabIndex = 7;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(29, 65);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "Picture";
            // 
            // xmlTreeView
            // 
            this.xmlTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xmlTreeView.Location = new System.Drawing.Point(13, 46);
            this.xmlTreeView.Name = "xmlTreeView";
            this.xmlTreeView.Size = new System.Drawing.Size(297, 741);
            this.xmlTreeView.TabIndex = 17;
            this.xmlTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.xmlTreeView_AfterSelect);
            this.xmlTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.xmlTreeView_NodeMouseDoubleClick);
            // 
            // XMLReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 799);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.functionGroupBox);
            this.Controls.Add(this.saveXMLFile);
            this.Controls.Add(this.importFile);
            this.Controls.Add(this.categoryControl);
            this.Controls.Add(this.stepsControl);
            this.Controls.Add(this.xmlTreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XMLReader";
            this.Text = "XML Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryControl)).EndInit();
            this.categoryControl.ResumeLayout(false);
            this.categoryControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsControl)).EndInit();
            this.stepsControl.ResumeLayout(false);
            this.stepsControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.functionGroupBox)).EndInit();
            this.functionGroupBox.ResumeLayout(false);
            this.functionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton importFile;
        private DevExpress.XtraEditors.SimpleButton saveXMLFile;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label subCategory;
        private System.Windows.Forms.TextBox subCategoryTextBox;
        private DevExpress.XtraEditors.GroupControl categoryControl;
        private DevExpress.XtraEditors.GroupControl stepsControl;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label stepsLabel;
        private DevExpress.XtraEditors.GroupControl functionGroupBox;
        private System.Windows.Forms.TextBox variable2TextBox;
        private System.Windows.Forms.TextBox variable1TextBox;
        private System.Windows.Forms.TextBox functionTextBox;
        private DevExpress.XtraEditors.LabelControl functionLabel;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl variable1Name;
        private System.Windows.Forms.TextBox variable4TextBox;
        private System.Windows.Forms.TextBox variable3TextBox;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton picture3Button;
        private System.Windows.Forms.TextBox pictureTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton videoButton;
        private System.Windows.Forms.TextBox videoTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.TreeView xmlTreeView;
        private DevExpress.XtraEditors.SimpleButton picture2Button;
        private System.Windows.Forms.TextBox subCatPicTextBox;
        private System.Windows.Forms.TextBox categoryPictureTextBox;
        private DevExpress.XtraEditors.SimpleButton picture1Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

