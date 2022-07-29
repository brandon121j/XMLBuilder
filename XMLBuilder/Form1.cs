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
        public Dictionary<string, string> subCatPictureFile = new Dictionary<string, string>();
        public string xmlFilePath = "";
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

                XmlNodeList subcategoryNode = doc.GetElementsByTagName("SubCategory");
                XmlNodeList titleNode = doc.GetElementsByTagName("Title");
                XmlNodeList typeNode = doc.GetElementsByTagName("Type");
                XmlNodeList weightNode = doc.GetElementsByTagName("Weight");
                XmlNodeList recordPictureNode = doc.GetElementsByTagName("RecordPicture");
                XmlNodeList pictureNode = doc.GetElementsByTagName("Picture");
                XmlNodeList videoNode = doc.GetElementsByTagName("Video");

                Dictionary<int, string> titleItems = new Dictionary<int, string>();
                Dictionary<int, string> textItems = new Dictionary<int, string>();
                Dictionary<int, string> typeItems = new Dictionary<int, string>();
                Dictionary<int, string> weightItems = new Dictionary<int, string>();
                Dictionary<int, string> recordPicturesItems = new Dictionary<int, string>();
                Dictionary<int, string> pictureItems = new Dictionary<int, string>();
                Dictionary<int, string> videoItems = new Dictionary<int, string>();

                reader.MoveToContent();

                for (int i = 0; i < subcategoryNode.Count; i++)
                {

                    titleItems.Add(i, titleNode[i].InnerText);
                    textItems.Add(i, titleNode[i].InnerText);
                    typeItems.Add(i, typeNode[i].InnerText);
                    weightItems.Add(i, weightNode[i].InnerText);
                    recordPicturesItems.Add(i, recordPictureNode[i].InnerText);
                    pictureItems.Add(i, pictureNode[i].InnerText);
                    videoItems.Add(i, videoNode[i].InnerText);
                }

                int categoryCounter = -1;
                int subCategoryCounter = -1;
                int stepsCounter = 0;
                int variableCounter = 1;

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
                                break;
                            case "SubCategory":
                                xmlTreeView.Nodes[categoryCounter].Nodes.Add($"{reader.LocalName}: {reader.GetAttribute(0)}");
                                subCatPictureFile.Add(reader.GetAttribute(0), reader.GetAttribute(2));
                                subCategoryCounter++;
                                break;
                            case "Steps":
                                xmlTreeView.Nodes[categoryCounter].Nodes[stepsCounter].Nodes.Add($"Title: {titleItems[stepsCounter]}");
                                xmlTreeView.Nodes[categoryCounter].Nodes[stepsCounter].Nodes.Add($"Text: {textItems[stepsCounter]}");
                                xmlTreeView.Nodes[categoryCounter].Nodes[stepsCounter].Nodes.Add($"Type: {typeItems[stepsCounter]}");
                                xmlTreeView.Nodes[categoryCounter].Nodes[stepsCounter].Nodes.Add($"Weight: {weightItems[stepsCounter]}");
                                xmlTreeView.Nodes[categoryCounter].Nodes[stepsCounter].Nodes.Add($"Picture: {pictureItems[stepsCounter]}");
                                xmlTreeView.Nodes[categoryCounter].Nodes[stepsCounter].Nodes.Add($"Video: {videoItems[stepsCounter]}");
                                stepsCounter = subCategoryCounter;
                                break;
                            case "Function":
                                variableCounter = 1;
                                xmlTreeView.Nodes[categoryCounter].Nodes[stepsCounter - 1].Nodes.Add($"Function: {reader.GetAttribute(0)}");
                                break;
                            case "Variable":
                                xmlTreeView.Nodes[categoryCounter].Nodes[stepsCounter - 1].Nodes[6].Nodes.Add($"Variable{variableCounter}: {reader.GetAttribute(0)}");
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
                    // Clears all text boxes
                    ClearTextboxes(this.Controls);

                    bool hasFunction = false;

                    // Gets Category nodes category portion of string and value portion
                    string parentNodeCategory = e.Node.Parent.Text.Split(' ').FirstOrDefault();
                    string parentNode = e.Node.Parent.Text.Substring(parentNodeCategory.Length + 1);

                    // Sets category text boxes
                    categoryTextBox.Text = parentNode;
                    categoryPictureTextBox.Text = categoryPictureFile[parentNode];

                    // Gets SubCategory nodes category portion of string and value portion
                    string subCatNodeCategory = e.Node.Text.Split(' ').FirstOrDefault();
                    string subCatNode = e.Node.Text.Substring(subCatNodeCategory.Length + 1);

                    // Sets SubCategory text boxes
                    subCategoryTextBox.Text = subCatNode;
                    subCatPicTextBox.Text = subCatPictureFile[subCatNode];

                    foreach (TreeNode nodes in e.Node.Nodes)
                    {
                        // Gets category from string
                        string category = nodes.Text.Split(' ').FirstOrDefault();

                        // Gets value from string
                        string nodeValue = nodes.Text.Substring(category.Length + 1);

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
                    titleTextBox.Text = selectedNode;
                    break;
                case "Text:":
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
            XmlDocument savingXML = new XmlDocument();

            



            //XmlTextWriter textWriter
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
    }


}
