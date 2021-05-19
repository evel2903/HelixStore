using HelixStore.Business.Products.Manage;
using HelixStore.Business.Products.Public;
using HelixStore.Data.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelixStore.WinForm.Forms
{
    public partial class ProductForm : Form
    {
        private ManageProductService manageService = new ManageProductService();
        private PublicProductService pulicService = new PublicProductService();
        private List<ProductType> productTypes;
        private readonly string dataSrcPath = @"C:\Users\evell\Desktop\2-2020-2021\XDPMPL\HelixStore\HelixStore.Data\Images\";
        private ImageSave imageSave;

        public ProductForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            btn_del.Enabled = false;
            btn_edit.Enabled = false;

            productTypes = pulicService.GetProductType();
            LoadProductType();

            

            LoadTable();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void LoadProductType()
        {
            productTypes.ForEach(prdt =>
            {
                search_product_type.Items.Add(prdt.ProductTypeId + " - " + prdt.ProductTypeName);
                product_type.Items.Add(prdt.ProductTypeId + " - " + prdt.ProductTypeName);
            });
            search_product_type.SelectedIndex = 0;
            product_type.SelectedIndex = 0;
        }

        private void search_product_type_SelectedValueChanged(object sender, EventArgs e)
        {
            product_type.SelectedIndex = search_product_type.SelectedIndex;
            ResetFormInput();
            LoadTable();
        }

        private void LoadTable()
        {
            product_table.Rows.Clear();
            List<Product> products = new PublicProductService().GetProductByType(search_product_type.SelectedIndex);

            products.ForEach(s =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(product_table);

                row.Cells[0].Value = s.ProductId;
                row.Cells[1].Value = s.ProductName;
                row.Cells[2].Value = s.ProductAmount;
                row.Cells[3].Value = s.ProductPrice;
                row.Cells[4].Value = s.ProductDescription;
                row.Cells[5].Value = s.ProductTypeId;
                row.Cells[6].Value = s.ProductImg;
                product_table.Rows.Add(row);
            });

        }

        private void product_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = product_table.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    btn_add.Enabled = false;
                    btn_del.Enabled = true;
                    btn_edit.Enabled = true;
                    update_amount.Enabled = true;
                    btn_add_img.Enabled = true;
                    Product product = GetProductInTableRow(row);

                    product_id.Text = product.ProductId.ToString();
                    product_name.Text = product.ProductName;
                    product_amount.Text = product.ProductAmount.ToString();
                    product_price.Text = product.ProductPrice.ToString();
                    product_description.Text = product.ProductDescription;
                    product_type.SelectedIndex = product.ProductTypeId;

                    if(product.ProductImg == null)
                    {
                        product_img.Image = null;
                    }
                    else
                    {
                       
                        Image i = Image.FromFile(dataSrcPath + product.ProductId + @"\" + product.ProductImg);
                        product_img.Image = i;
                    }
                }

            }
        }

        private Product GetProductInTableRow(DataGridViewRow row)
        {
            Product product = new Product();

            product.ProductId = int.Parse(row.Cells[0].Value.ToString());
            product.ProductName = row.Cells[1].Value.ToString();
            product.ProductAmount = int.Parse(row.Cells[2].Value.ToString());
            product.ProductPrice = Decimal.Parse(row.Cells[3].Value.ToString());
            product.ProductDescription = row.Cells[4].Value.ToString();
            product.ProductTypeId = int.Parse(row.Cells[5].Value.ToString());
            product.ProductImg = row.Cells[6].Value == null ? null : row.Cells[6].Value.ToString();

            return product;
        }

        private void ResetFormInput()
        {
            btn_add.Enabled = true;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
            update_amount.Enabled = false;
            btn_add_img.Enabled = false;



            product_id.Text = "-1";
            product_name.Text = "";
            product_amount.Text = "";
            product_price.Text = "";
            product_description.Text = "";
            product_type.SelectedIndex = search_product_type.SelectedIndex;
            product_img.Image = null;
        }

        private Product GetProduct()
        {
            Product product = new Product();

            product.ProductId = int.Parse(product_id.Text);
            product.ProductName = product_name.Text;
            product.ProductAmount = product_amount.TextLength <= 0 ? 0 : int.Parse(product_amount.Text);
            product.ProductPrice = Decimal.Parse(product_price.TextLength <= 0 ? "0" : product_price.Text);
            product.ProductDescription = product_description.Text;
            product.ProductTypeId = product_type.SelectedIndex;
            product.ProductImg = imageSave.fileName == null ? null : imageSave.fileName;

            return product;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetFormInput();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (manageService.Create(GetProduct()) != null)
            {
                MessageBox.Show("Success!");
                ResetFormInput();
                
            }
            else
            {
                MessageBox.Show("Failed!");
            }

            LoadTable();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Product product = GetProduct();
            if (manageService.Delete(product.ProductId) != null)
            {
                MessageBox.Show("Success!");
                ResetFormInput();
                
            }
            else
            {
                MessageBox.Show("Failed!");
            }

            LoadTable();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Product product = GetProduct();
            if (manageService.Update(product.ProductId, product) != null)
            {
                MessageBox.Show("Success!");


                if (imageSave.toPath != null && imageSave.currentPath != null)
                {
                    try
                    {
                        File.Copy(imageSave.currentPath, imageSave.toPath);
                    }
                    catch
                    {

                    }
                }
                ResetFormInput();

            }
            else
            {
                MessageBox.Show("Failed!");
            }
            LoadTable();
        }

        private void update_amount_Click(object sender, EventArgs e)
        {
            int irAmount = int.Parse(Interaction.InputBox("Enter product quantity", "Inventory Receiving"));
            var product = GetProduct();
            
            if (manageService.InventoryReceiving(irAmount, product.ProductId) != null)
            {
                MessageBox.Show("Success!");
                ResetFormInput();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
            LoadTable();

        }

        private void btn_add_img_Click(object sender, EventArgs e)
        {

            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            string dataPath = dataSrcPath + product_id.Text + @"\"; // <---
            if (Directory.Exists(dataPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(dataPath);                                              // <---
            }                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;   // <---
                    string filePath = opFile.FileName;    // <---
                    product_img.Image = new Bitmap(opFile.OpenFile());

                    string imgPath = dataPath + iName;
                    //File.Copy(filePath, imgPath); // <---

                    imageSave = new ImageSave(filePath, imgPath, iName);

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }
    }
}
