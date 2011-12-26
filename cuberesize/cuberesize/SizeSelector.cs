using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace cuberesize
{
    public partial class SizeSelector : Form
    {
        private const string CUBERESIZE_LAYOUT_TAG = "cuberesize";
        private const string CUBERESIZE_CATEGORY_TAG = "category";
        private const string CUBERESIZE_ID_TAG = "id";
        private const string CUBERESIZE_TEXT_TAG = "text";
        private const string CUBERESIZE_WIDTH_TAG = "width";
        private const string CUBERESIZE_HEIGHT_TAG = "height";

        public class ItemInfo
        {
            public int width { get; private set; }
            public int height { get; private set; }
            public string category { get; private set; }
            public string id { get; private set; }
            public string name { get; private set; }

            public ItemInfo(string id, string category, string name, int width, int height)
            {
                this.id = id;
                this.category = category;
                this.width = width;
                this.height = height;
                this.name = name;
            }

            public override string ToString()
            {
                return name;
            }
        }

        public ItemInfo SelectedItem
        {
            get
            {
                for (int i = 0; i < tableLayout.RowCount; ++i)
                    if (((RadioButton)tableLayout.GetControlFromPosition(0, i)).Checked)
                        return (ItemInfo)((ComboBox)tableLayout.GetControlFromPosition(1, i)).SelectedItem;
                return new ItemInfo(null, null, null, 0, 0);
            }
        }

        public SizeSelector(string layoutXml)
        {
            InitializeComponent();

            try
            {
                using (XmlTextReader xmlReader = new XmlTextReader(layoutXml))
                {
                    while (xmlReader.Read())
                    {
                        if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == CUBERESIZE_LAYOUT_TAG)
                            break;
                    }
                    if (xmlReader.Name != CUBERESIZE_LAYOUT_TAG)
                        return;

                    while (xmlReader.Read())
                    {
                        switch (xmlReader.NodeType)
                        {
                            case XmlNodeType.Element:
                                if (xmlReader.Name == CUBERESIZE_CATEGORY_TAG)
                                    CreateCategoryWindow(xmlReader);
                                break;

                            case XmlNodeType.EndElement:
                                if (xmlReader.Name == CUBERESIZE_LAYOUT_TAG)
                                {
                                    ((RadioButton)tableLayout.GetControlFromPosition(0, 0)).Checked = true;
                                    return;
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void CreateCategoryWindow(XmlReader xmlReader)
        {
            RadioButton categoryCheckBox = new RadioButton();
            ComboBox itemComboBox = new ComboBox();

            categoryCheckBox.CheckedChanged += new EventHandler(categoryCheckBox_CheckedChanged);
            itemComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (tableLayout.GetControlFromPosition(0, tableLayout.RowCount - 1) != null)
                tableLayout.RowCount++;
            tableLayout.Controls.Add(categoryCheckBox, 0, tableLayout.RowCount - 1);
            tableLayout.Controls.Add(itemComboBox, 1, tableLayout.RowCount - 1);

            if (xmlReader.MoveToFirstAttribute())
            {
                do
                {
                    switch (xmlReader.Name)
                    {
                        case CUBERESIZE_ID_TAG:
                            categoryCheckBox.Tag = xmlReader.Value;
                            break;

                        case CUBERESIZE_TEXT_TAG:
                            categoryCheckBox.Text = xmlReader.Value;
                            break;
                    }
                } while (xmlReader.MoveToNextAttribute());
            }

            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (xmlReader.MoveToFirstAttribute())
                        {
                            string id = null;
                            string name = null;
                            int width = 0;
                            int height = 0;
                            do
                            {
                                switch (xmlReader.Name)
                                {
                                    case CUBERESIZE_ID_TAG:
                                        id = xmlReader.Value;
                                        break;

                                    case CUBERESIZE_TEXT_TAG:
                                        name = xmlReader.Value;
                                        break;

                                    case CUBERESIZE_WIDTH_TAG:
                                        width = Convert.ToInt32(xmlReader.Value);
                                        break;

                                    case CUBERESIZE_HEIGHT_TAG:
                                        height = Convert.ToInt32(xmlReader.Value);
                                        break;
                                }
                            } while (xmlReader.MoveToNextAttribute());
                            itemComboBox.Items.Add(new ItemInfo(id, categoryCheckBox.Text, name, width, height));
                        }
                        break;

                    case XmlNodeType.EndElement:
                        if (xmlReader.Name == CUBERESIZE_CATEGORY_TAG)
                        {
                            itemComboBox.SelectedIndex = 0;
                            return;
                        }
                        break;
                }
            }
        }

        void categoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < tableLayout.RowCount; ++i)
                if (((RadioButton)tableLayout.GetControlFromPosition(0, i)).Checked)
                    tableLayout.GetControlFromPosition(1, i).Enabled = true;
                else
                    tableLayout.GetControlFromPosition(1, i).Enabled = false;
        }
    }
}
