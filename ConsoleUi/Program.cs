// See https://aka.ms/new-console-template for more information
using ConsoleUi;

IBaseManager bs=new BaseManager();
bs.Add(new Product() { Name = "Iphone" });
bs.Add(new Category() { Name = "Telefon" });

IEntity ent = new Product();
IEntity ent2 = new Category();


