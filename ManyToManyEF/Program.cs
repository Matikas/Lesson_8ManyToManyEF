using ManyToManyEF.Persistence;
using ManyToManyEF.Persistence.Models;
using System.Text;

var repository = new BooksRepository();

var harryPotterBook = new Book("Harry Potter");
var lordOfRings = new Book("Lort of the Rings");

var adveturesCategory = new Category("Adventure");
adveturesCategory.Books.Add(harryPotterBook);

var fantasyCategory = new Category("Fantasy");
fantasyCategory.Books.Add(harryPotterBook);
fantasyCategory.Books.Add(lordOfRings);


repository.CreateCategory(adveturesCategory);
repository.CreateCategory(fantasyCategory);
repository.SaveChanges();
