using Hotcakes.CommerceDTO.v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Contacts;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.Web.Data;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kliensalkalmazás
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetProducts();


        }

        private void ModifyPriceButton_Click(object sender, EventArgs e)
        {

            string url = "http://20.234.113.211:8095/";
            string key = "1-b5b9e594-8ab1-4574-b338-1c46551eb3e8";

            Api proxy = new Api(url, key);

            int rowIndex = DataGridView.CurrentCell.RowIndex;

            var productId = DataGridView.Rows[rowIndex].Cells["Bvin"].Value.ToString();

            // call the API to find the product to update
            var product = proxy.ProductsFind(productId).Content;

            // modify product price
            product.SitePrice = decimal.Parse(ModifyTextBox.Text);

            // update product through api call
            ApiResponse<ProductDTO> response = proxy.ProductsUpdate(product);
            ModifyTextBox.Clear();


            GetProducts();

        }
        public void GetProducts()
        {

            string url = "http://20.234.113.211:8086";
            string key = "1-b5b9e594-8ab1-4574-b338-1c46551eb3e8";
            Api proxy = new Api(url, key);

            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();

            string json = JsonConvert.SerializeObject(response);

            ApiResponse<List<ProductDTO>> deserializedResponse = JsonConvert.DeserializeObject<ApiResponse<List<ProductDTO>>>(json);


            DataTable dt = new DataTable();

            dt.Columns.Add("bvin", typeof(string)); 
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("Price", typeof(int));



            foreach (ProductDTO item in deserializedResponse.Content)
            {
                dt.Rows.Add(item.Bvin, item.ProductName, item.SitePrice.ToString("F0") + " Ft");
            }


            DataGridView.DataSource = dt;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            string url = "http://20.234.113.211:8086";
            string key = "1-b5b9e594-8ab1-4574-b338-1c46551eb3e8";

            Api proxy = new Api(url, key);

            // specify the product to delete
            int rowIndex = DataGridView.CurrentCell.RowIndex;
            int columnIndex = DataGridView.CurrentCell.ColumnIndex;

            var ProductId = DataGridView[columnIndex, rowIndex].Value.ToString();

            // call the API to delete the order
            ApiResponse<bool> response = proxy.ProductsDelete(ProductId);

            GetProducts();
        }
    }
}