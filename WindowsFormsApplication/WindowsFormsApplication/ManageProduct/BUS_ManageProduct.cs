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
        CMART2Entities db = new CMART2Entities();

        public List<Product> loadAllListProduct()
        {
            var db = new CMART2Entities();
            return db.Products.ToList();
        }

        private bool checkExistProduct(string name)
        {
            using (var db = new CMART2Entities())
                return db.Products.Count(s => s.ProductName == name) > 0;
        }

        public bool insertNewProduct(string name, string image, string type, string supplier)
        {
            if (!checkExistProduct(name))
                try
                {
                    using (var db = new CMART2Entities())
                    {
                        ObjectParameter Output = new ObjectParameter("CODE", typeof(String));
                        db.SP_PRODUCT_ID_AUTO(Output);
                        var id = Output.Value.ToString();
                        var product = new Product
                        {
                            ProductCode = id,
                            ProductName = name,
                            Image = image,
                            TypeCode = type,
                            SupplierCode = supplier
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

        public bool updateNewProduct(string id, string name, string image, string type, string supplier)
        {
            if (!checkExistProduct(name))
                try
                {
                    using (var db = new CMART2Entities())
                    {
                        var product = db.Products.Single(p => p.ProductCode == id);
                        product.ProductName = name;
                        product.Image = image;
                        product.TypeCode = type;
                        product.SupplierCode = supplier;
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

        private bool checkExistpProduct(string id)
        {
            using (var db = new CMART2Entities())
                return db.Products.Count(s => s.ProductCode == id) == 1;
        }

        public bool deleteProduct(string id)
        {
            if (checkExistpProduct(id))
                try
                {
                    using (var db = new CMART2Entities())
                    {
                        var product = db.Products.Single(s => s.ProductCode == id);
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
    }
}
