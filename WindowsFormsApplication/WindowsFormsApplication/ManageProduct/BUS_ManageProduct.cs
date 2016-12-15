using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication.ManageProduct
{
    class BUS_ManageProduct
    {
        CMART2Entities1 db = new CMART2Entities1();

        public List<Product> loadAllListProduct()
        {
            var db = new CMART2Entities1();
            return db.Products.ToList();
        }

        private bool checkExistProduct(string productName)
        {
            using (var db = new CMART2Entities1())
                return db.Products.Count(s => s.ProductName == productName) > 0;
        }

        public bool insertNewProduct(string productName, string image, string typeCode, string supplierCode)
        {
            if (!checkExistProduct(productName))
                try
                {
                    using (var db = new CMART2Entities1())
                    {
          
                        ObjectParameter Output = new ObjectParameter("CODE", typeof(String));
                        db.SP_PRODUCT_ID_AUTO(Output);
                        var id_auto = Output.Value.ToString();

                        var product = new Product
                        {
                            ProductCode = id_auto,
                            ProductName = productName,
                            Image = image,
                            TypeCode = typeCode,
                            SupplierCode = supplierCode
                        };
                        db.Products.Add(product);
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            return false;
        }

        private bool checkExistProduct(string productName, string image, string typeCode, string supplierCode)
        {
            using (var db = new CMART2Entities1())
            {
                if (db.Products.Count(s => s.ProductName == productName 
                                        && s.Image == image
                                        && s.TypeCode == typeCode
                                        && s.SupplierCode == supplierCode) > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool updateNewProduct(string productCode, string productName, string image, string typeCode, string supplierCode)
        {
            //Mean of if: Nothing change => Can't update!
            if (!checkExistProduct(productName, image, typeCode, supplierCode))
                try
                {
                    using (var db = new CMART2Entities1())
                    {
                        var product = db.Products.Single(p => p.ProductCode == productCode);
                        product.ProductName = productName;
                        product.Image = image;
                        product.TypeCode = typeCode;
                        product.SupplierCode = supplierCode;
                        db.Entry(product).State = EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            return false;
        }

        private bool checkExistProductCode(string productCode)
        {
            using (var db = new CMART2Entities1())
                return db.Products.Count(s => s.ProductCode == productCode) == 1;
        }

        public bool deleteProduct(string productCode)
        {
            if (checkExistProductCode(productCode))
                try
                {
                    using (var db = new CMART2Entities1())
                    {
                        var product = db.Products.Single(s => s.ProductCode == productCode);
                        db.Products.Remove(product);
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            return false;
        }

        public List<usp_ProductSearch_Result> searchListProduct(string text)
        {
            var db = new CMART2Entities1();
            return db.usp_ProductSearch(text).ToList();
        }
    }
}
