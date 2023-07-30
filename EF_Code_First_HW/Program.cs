

using EF_Code_First_HW;

using Db db = new Db();

Product p1 = new Product() { Title = "pr_1", Description = "desc_1", Price = 139.99 };
Product p2 = new Product() { Title = "pr_2", Description = "desc_2", Price = 149.99 };

User u1 = new User() { Name = "John", Email = "john@gmail.com", Password = "123123123" };

db.Products.AddRange(p1, p2);
db.Users.AddRange(u1);

db.SaveChanges();
