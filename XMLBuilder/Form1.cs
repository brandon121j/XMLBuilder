using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XMLBuilder
{
    public partial class XMLReader : Form
    {
        // These two are used to access pictures on click later in the application
        public Dictionary<string, string> categoryPictureFile = new Dictionary<string, string>();
        public string xmlFilePath = "";

        public int titleIndex = 0;
        public int textIndex = 0;
        public int typeIndex = 0;


        public XMLReader()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void xmlTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void picture1Button_Click(object sender, EventArgs e)
        {

            OpenFileDialog categoryPicFile = new OpenFileDialog();

            categoryPicFile.InitialDirectory = @"C:\\Pictures";

            categoryPicFile.Filter = "Image Files (*.jpg) | *.jpg";

            DialogResult dialogResults = categoryPicFile.ShowDialog();

            if (dialogResults == DialogResult.OK)
            {
                categoryPictureTextBox.Text = categoryPicFile.SafeFileName;

            }
        }

        private void subCatPicTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void picture2Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog subCatPicFile = new OpenFileDialog();

            subCatPicFile.InitialDirectory = @"C:\\Pictures";

            subCatPicFile.Filter = "Image Files (*.jpg) | *.jpg";

            DialogResult dialogResults = subCatPicFile.ShowDialog();

            if (dialogResults == DialogResult.OK)
            {
                subCatPicTextBox.Text = subCatPicFile.SafeFileName;

            }
        }

        private void importFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog importFile = new OpenFileDialog();

            //importFile.InitialDirectory = @"C:\\Pictures";

            importFile.Filter = "XML Files (*.xml)|*.xml"; ;

            DialogResult dialogResults = importFile.ShowDialog();

            if (dialogResults == DialogResult.OK)
            {

                xmlFilePath = importFile.FileName;

            }

            try
            {

                XmlDocument doc = new XmlDocument();

                doc.Load(xmlFilePath);

                XmlReader reader = XmlReader.Create(xmlFilePath);

                reader.MoveToContent();

                int categoryCounter = -1;
                int subCategoryCounter = -1;
                int stepsCounter = -1;
                int stepCounter = -1;
                int choiceCounter = 0;
                int choiceNodeFinder = 0;
                int measurementCounter = 0;
                int measurementNodeFinder = 0;
                int variableCounter = 0;
                int variableNodeFinder = 0;

                // Makes all group boxes invisible so they can be dynamically added later
                meaurementsGroupBox.Visible = false;
                choicesGroupBox.Visible = false;
                functionGroupBox.Visible = false;

                // Clears all nodes and clears dictionary storage 
                xmlTreeView.Nodes.Clear();
                categoryPictureFile.Clear();


                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {

                        switch (reader.LocalName)
                        {
                            case "Category":
                                xmlTreeView.Nodes.Add($"{reader.LocalName}: {reader.GetAttribute(0)}");
                                categoryPictureFile.Add(reader.GetAttribute(0), reader.GetAttribute(2));
                                categoryCounter++;
                                subCategoryCounter = -1;
                                break;
                            case "SubCategory":
                                xmlTreeView.Nodes[categoryCounter].Nodes.Add($"{reader.LocalName}: {reader.GetAttribute(0)}   PicFile: {reader.GetAttribute(2)}");

                                stepsCounter = -1;
                                subCategoryCounter++;
                                break;
                            case "Steps":
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes.Add("Steps");
                                stepCounter = -1;
                                stepsCounter++;
                                break;
                            case "Step":
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes.Add("Step");
                                choiceNodeFinder = 0;
                                measurementNodeFinder = 0;
                                variableNodeFinder = 0;
                                stepCounter++;
                                break;
                            case "Title":
                                choiceNodeFinder++;
                                measurementNodeFinder++;
                                variableNodeFinder++;
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes.Add($"Title: {reader.ReadElementContentAsString()}");

                                break;
                            case "Text":
                                choiceNodeFinder++;
                                measurementNodeFinder++;
                                variableNodeFinder++;
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes.Add($"Text: {reader.ReadElementContentAsString()}");

                                break;
                            case "Type":
                                choiceNodeFinder++;
                                measurementNodeFinder++;
                                variableNodeFinder++;
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes.Add($"Type: {reader.ReadElementContentAsString()}");

                                break;
                            case "Weight":
                                choiceNodeFinder++;
                                measurementNodeFinder++;
                                variableNodeFinder++;
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes.Add($"Weight: {reader.ReadElementContentAsString()}");

                                break;
                            case "RecordPicture":
                                choiceNodeFinder++;
                                measurementNodeFinder++;
                                variableNodeFinder++;
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes.Add($"RecordPicture: {reader.ReadElementContentAsString()}");

                                break;
                            case "Picture":
                                choiceNodeFinder++;
                                measurementNodeFinder++;
                                variableNodeFinder++;
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes.Add($"Picture: {reader.ReadElementContentAsString()}");

                                break;
                            case "Video":
                                choiceNodeFinder++;
                                measurementNodeFinder++;
                                variableNodeFinder++;
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes.Add($"Video: {reader.ReadElementContentAsString()}");

                                break;
                            case "Choices":
                                choicesGroupBox.Visible = true;
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes.Add($"Choices: {reader.GetAttribute(0)}");
                                measurementNodeFinder++;
                                variableNodeFinder++;
                                choiceCounter = 0;
                                break;
                            case "Choice":
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes[choiceNodeFinder].Nodes.Add($"Choice_Title{choiceCounter + 1}: {reader.GetAttribute(0)}");
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes[choiceNodeFinder].Nodes[choiceCounter].Nodes.Add($"Choice_Picture{choiceCounter + 1}: {reader.GetAttribute(2)}");
                                choiceCounter++;
                                measurementNodeFinder++;
                                break;
                            case "Measurements":
                                meaurementsGroupBox.Visible = true;
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes.Add($"Measurements: ");
                                variableNodeFinder++;
                                measurementCounter = 0;
                                
                                break;
                            case "Measurement":
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes[measurementNodeFinder].Nodes.Add($"Measurement_Title{measurementCounter + 1}: {reader.GetAttribute(0)}");
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes[measurementNodeFinder].Nodes[measurementCounter].Nodes.Add($"Measurement_Type{measurementCounter + 1}: {reader.GetAttribute(1)}");
                                measurementCounter++;
                                //xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes.Add($"Function: {reader.GetAttribute(0)}");
                                break;
                            case "Function":
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes.Add($"Function: {reader.GetAttribute(0)}");
                                functionGroupBox.Visible = true;
                                variableCounter = 0;
                                break;
                            case "Variable":
                                xmlTreeView.Nodes[categoryCounter].Nodes[subCategoryCounter].Nodes[stepsCounter].Nodes[stepCounter].Nodes[variableNodeFinder].Nodes.Add($"Variable_Name{variableCounter + 1}: {reader.GetAttribute(0)}");

                                variableCounter++;
                                break;
                        }


                    }


                }


                reader.Close();

            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }
    
        private void xmlTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            // Selects category portion of string
            string selectedTextBox = e.Node.Text.Split(' ').FirstOrDefault();

            string selectedNode = e.Node.Text.Contains(' ') ? e.Node.Text.Substring(selectedTextBox.Length + 1) : selectedTextBox;


            switch (selectedTextBox)
            {
                case "Category:":
                        categoryTextBox.Text = selectedNode;
                        categoryPictureTextBox.Text = categoryPictureFile[selectedNode];
                        break;
                case "SubCategory:":
                    subCategoryTextBox.Text = selectedNode;
                    subCatPicTextBox.Text = selectedNode.Split(' ').LastOrDefault();
                    break;

                case "Step":

                    ClearTextboxes(this.Controls);

                    bool hasFunction = false;

                    // Gets Category nodes category portion of string and value portion
                    string parentNodeCategory = e.Node.Parent.Parent.Parent.Text.Split(' ').FirstOrDefault();
                    string parentNode = e.Node.Parent.Parent.Parent.Text.Substring(parentNodeCategory.Length + 1);

                    //Console.WriteLine(parentNode);

                    // Sets category text boxes
                    categoryTextBox.Text = parentNode;
                    categoryPictureTextBox.Text = categoryPictureFile[parentNode];

                    // Gets SubCategory nodes category portion of string and value portion
                    string subCatNodeCategory = e.Node.Parent.Parent.Text.Split(' ').FirstOrDefault();
                    string subCatNode = e.Node.Parent.Parent.Text.Substring(subCatNodeCategory.Length + 1);
                    subCatNode = subCatNode.Substring(0, subCatNode.IndexOf("PicFile:"));

                    string subCatNodePic = e.Node.Parent.Parent.Text.Split(' ').LastOrDefault();

                    //Console.WriteLine(subCatNodeCategory);


                    // Sets SubCategory text boxes
                    subCategoryTextBox.Text = subCatNode;
                    subCatPicTextBox.Text = subCatNodePic;

                    foreach (TreeNode nodes in e.Node.Nodes)
                    {
                        // Gets category from string
                        string category = nodes.Text.Split(' ').FirstOrDefault();

                        //Console.WriteLine(category);

                        // Gets value from string
                        string nodeValue = nodes.Text.Substring(category.Length + 1);

                        Console.WriteLine(nodeValue);


                        switch (category)
                        {
                            case "Title:":
                                titleTextBox.Text = nodeValue;
                                break;
                            case "Text:":
                                textTextBox.Text = nodeValue;
                                break;
                            case "Type:":
                                typeTextBox.Text = nodeValue;
                                break;
                            case "Weight:":
                                weightTextBox.Text = nodeValue;
                                break;
                            case "Picture:":
                                pictureTextBox.Text = nodeValue;
                                break;
                            case "Video:":
                                videoTextBox.Text = nodeValue;
                                break;
                            case "Function:":
                                functionTextBox.Text = nodeValue;
                                xmlTreeView.SelectedNode = nodes;
                                hasFunction = true;
                                break;
                            case "Measurements:":

                                break;

                        }

                        // Creates loop that iterates through variables elements 
                        if (hasFunction)
                        {
                            foreach (TreeNode item in xmlTreeView.SelectedNode.Nodes)
                            {
                                // This gets first part of string which contains the category of the item
                                string variable = item.Text.Split(' ').FirstOrDefault();

                                // Gets the actual value from the string
                                string selectedVariable = item.Text.Substring(variable.Length + 1);

                                switch (variable)
                                {
                                    case "Variable1:":
                                        variable1TextBox.Text = selectedVariable;
                                        break;
                                    case "Variable2:":
                                        variable2TextBox.Text = selectedVariable;
                                        break;
                                    case "Variable3:":
                                        variable3TextBox.Text = selectedVariable;
                                        break;
                                    case "Variable4:":
                                        variable4TextBox.Text = selectedVariable;
                                        break;
                                }
                            }

                        }

                    }

                    break;
                case "Title:":
                    titleIndex = e.Node.Index;
                    titleTextBox.Text = selectedNode;
                    break;
                case "Text:":
                    textIndex = e.Node.Index;
                    textTextBox.Text = selectedNode;
                    break;
                case "Type:":
                    typeTextBox.Text = selectedNode;
                    break;
                case "Weight:":
                    weightTextBox.Text = selectedNode;
                    break;
                case "Picture:":
                    pictureTextBox.Text = selectedNode;
                    break;
                case "Video:":
                    videoTextBox.Text = selectedNode;
                    break;
                case "Function:":
                    functionTextBox.Text = selectedNode;
                    break;
                case "Variable1:":
                    variable1TextBox.Text = selectedNode;
                    break;
                case "Variable2:":
                    variable2TextBox.Text = selectedNode;
                    break;
                case "Variable3:":
                    variable3TextBox.Text = selectedNode;
                    break;
                case "Variable4:":
                    variable4TextBox.Text = selectedNode;
                    break;
                case "Measurement_Title1:":
                    measurement1TitleTB.Text = selectedNode;
                    break;
                case "Measurement_Title2:":
                    measurement2TitleTB.Text = selectedNode;
                    break;
                case "Measurement_Title3:":
                    measurement3TitleTB.Text = selectedNode;
                    break;
                case "Measurement_Type1:":
                    measurement1TypeTB.Text = selectedNode;
                    break;
                case "Measurement_Type2:":
                    measurement2TypeTB.Text = selectedNode;
                    break;
                case "Measurement_Type3:":
                    measurement3TypeTB.Text = selectedNode;
                    break;
                case "Choices:":
                    choicesTextBox.Text = selectedNode;
                    break;
                case "Choice_Title1:":
                    choice1TitleTB.Text = selectedNode;
                    break;
                case "Choice_Picture1:":
                    choice1PictureTB.Text = selectedNode;
                    break;
                case "Choice_Title2:":
                    choice2TitleTB.Text = selectedNode;
                    break;
                case "Choice_Picture2:":
                    choice2PictureTB.Text = selectedNode;
                    break;
                case "Choice_Title3:":
                    textBox2.Text = selectedNode;
                    break;
                case "Choice_Picture3:":
                    choice3PictureTB.Text = selectedNode;
                    break;
                case "Choice4:":
                    choice2TitleTB.Text = selectedNode;
                    //e.Node.Index();
                    break;



            }

        }

        public static void ClearTextboxes(Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                ClearTextboxes(ctrl.Controls);
            }
        }

        private void saveXMLFile_Click(object sender, EventArgs e)
        {
            
        }

        private void xmlTreeView_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;

        }

        private void xmlTreeView_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picture3Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog pictureFile = new OpenFileDialog();

            pictureFile.InitialDirectory = @"C:\\Pictures";

            pictureFile.Filter = "Image Files (*.jpg) | *.jpg";

            DialogResult dialogResults = pictureFile.ShowDialog();

            if (dialogResults == DialogResult.OK)
            {
                pictureTextBox.Text = pictureFile.SafeFileName;

            }
        }

        private void videoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog videoFile = new OpenFileDialog();

            videoFile.InitialDirectory = @"C:\\Pictures";

            videoFile.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav|All Files|*.*";

            DialogResult dialogResults = videoFile.ShowDialog();

            if (dialogResults == DialogResult.OK)
            {
                categoryPictureTextBox.Text = videoFile.SafeFileName;

            }
        }

        private void functionGroupBox_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void meaurementsGroupBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void choicesGroupBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void choice1FileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog pictureFile = new OpenFileDialog();

            pictureFile.InitialDirectory = @"C:\\Pictures";

            pictureFile.Filter = "Image Files (*.jpg) | *.jpg";

            DialogResult dialogResults = pictureFile.ShowDialog();

            if (dialogResults == DialogResult.OK)
            {
                choice1PictureTB.Text = pictureFile.SafeFileName;

            }
        }

        private void choice2FileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog pictureFile = new OpenFileDialog();

            pictureFile.InitialDirectory = @"C:\\Pictures";

            pictureFile.Filter = "Image Files (*.jpg) | *.jpg";

            DialogResult dialogResults = pictureFile.ShowDialog();

            if (dialogResults == DialogResult.OK)
            {
                choice2PictureTB.Text = pictureFile.SafeFileName;

            }
        }

        private void choice3FileBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog pictureFile = new OpenFileDialog();

            pictureFile.InitialDirectory = @"C:\\Pictures";

            pictureFile.Filter = "Image Files (*.jpg) | *.jpg";

            DialogResult dialogResults = pictureFile.ShowDialog();

            if (dialogResults == DialogResult.OK)
            {
                choice3PictureTB.Text = pictureFile.SafeFileName;

            }
        }

        private void importFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            XmlDocument savingXML = new XmlDocument();

            xmlTreeView.SelectedNode = xmlTreeView.Nodes[textIndex];

            xmlTreeView.SelectedNode.Text = textTextBox.Text;

            Console.WriteLine(xmlTreeView.SelectedNode);

            var title = titleTextBox.Text;

            var text = textTextBox.Text;

            var type = typeTextBox.Text;

            var weight = weightTextBox.Text;

            //XmlTextWriter textWriter
        }

        private void xmlTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //textIndex = e.Node.Index;
        }
    }


}
