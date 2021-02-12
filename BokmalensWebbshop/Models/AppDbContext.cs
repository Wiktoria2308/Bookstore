
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BokmalensWebbshop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fiction" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Tragedy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Drama" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Satire" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Comedy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Epic" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 7, CategoryName = "Adventure" });

            //seed books

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 1,
                Title = "1984",
                Author = "George Orwell",
                Price = 32.95M,
                Description = "Winston Smith works for the Ministry of Truth in London, chief city of Airstrip One. Big Brother stares out from every poster, the Thought Police uncover every act of betrayal. When Winston finds love with Julia, he discovers that life does not have to be dull and deadening, and awakens to new possibilities. Despite the police helicopters that hover and circle overhead, Winston and Julia begin to question the Party; they are drawn towards conspiracy. Yet Big Brother will not tolerate dissent - even in the mind. For those with original thoughts they invented Room 101. . .",
                CategoryId = 3,
                ImageUrl = "1984.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 2,
                Title = "Animal Farm",
                Author = "George Orwell",
                Price = 22.95M,
                Description = "When the downtrodden animals of Manor Farm overthrow their master Mr Jones and take over the farm themselves, they imagine it is the beginning of a life of freedom and equality. But gradually a cunning, ruthless elite among them, masterminded by the pigs Napoleon and Snowball, starts to take control. Soon the other animals discover that they are not all as equal as they thought, and find themselves hopelessly ensnared as one form of tyranny is replaced with another.",
                CategoryId = 4,
                ImageUrl = "Animal_Farm.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 3,
                Title = "The Catcher In The Rye",
                Author = "J.D. Salinger",
                Price = 42.95M,
                Description = "The brilliant, funny, meaningful novel(The New Yorker) that established J. D. Salinger as a leading voice in American literature and that has instilled in millions of readers around the world a lifelong love of books. \"If you really want to hear about it, the first thing you'll probably want to know is where I was born, and what my lousy childhood was like, and how my parents were occupied and all before they had me, and all that David Copperfield kind of crap, but I don't feel like going into it, if you want to know the truth.\" The hero-narrator of The Catcher in the Rye is an ancient child of sixteen, a native New Yorker named Holden Caufield. Through circumstances that tend to preclude adult, secondhand description, he leaves his prep school in Pennsylvania and goes underground in New York City for three days.",
                CategoryId = 5,
                ImageUrl = "Catcher_in_the_rye.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 4,
                Title = "Crime and Punishment",
                Author = "Fyodor Dostovjeskij",
                Price = 24.95M,
                Description = "Crime and Punishment is one of the greatest and most readable novels ever written. From the beginning we are locked into the frenzied consciousness of Raskolnikov who, against his better instincts, is inexorably drawn to commit a brutal double murder. From that moment on, we share his conflicting feelings of self-loathing and pride, of contempt for and need of others, and of terrible despair and hope of redemption: and, in a remarkable transformation of the detective novel, we follow his agonised efforts to probe and confront both his own motives for, and the consequences of, his crime.",
                CategoryId = 6,
                ImageUrl = "Crime_and_Punishment.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 5,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Price = 45.95M,
                Description = "Through the narration of Nick Carraway, the reader is taken into the superficially glittering world of the mansions which lined the Long Island shore in the 1920s, to encounter Nick's cousin Daisy, her brash but wealthy husband Tom Buchanan, Jay Gatsby and the mystery that surrounds him.",
                CategoryId = 5,
                ImageUrl = "Great_Gatsby.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 6,
                Title = "The Handmaid’s Tale",
                Author = "Margaret Atwood",
                Price = 33.95M,
                Description = "The Republic of Gilead offers Offred only one function: to breed. If she deviates, she will, like dissenters, be hanged at the wall or sent out to die slowly of radiation sickness. But even a repressive state cannot obliterate desire - neither Offred's nor that of the two men on which her future hangs. Brilliantly conceived and executed, this powerful evocation of twenty-first century America gives full rein to Margaret Atwood's devastating irony, wit and astute perception.",
                CategoryId = 1,
                ImageUrl = "Handmaids tale.jpg",
                InStock = true,
                IsBookOfTheWeek = true,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 7,
                Title = "Les Miserables",
                Author = "Victor Hugo",
                Price = 29.95M,
                Description = "Victor Hugo's tale of injustice, heroism and love follows the fortunes of Jean Valjean, an escaped convict determined to put his criminal past behind him. But his attempts to become a respected member of the community are constantly put under threat: by his own conscience, when, owing to a case of mistaken identity, another man is arrested in his place; and by the relentless investigations of the dogged Inspector Javert. It is not simply for himself that Valjean must stay free, however, for he has sworn to protect the baby daughter of Fantine, driven to prostitution by poverty.",
                CategoryId = 3,
                ImageUrl = "Les_miserables.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 8,
                Title = "Naked Lunch",
                Author = "William S. Burroughs",
                Price = 40.95M,
                Description = "Nightmarish and fiercely funny, William Burroughs' virtuoso, taboo-breaking masterpiece Naked Lunch follows Bill Lee through Interzone: a surreal, orgiastic wasteland of drugs, depravity, political plots, paranoia, sadistic medical experiments and endless, gnawing addiction. One of the most shocking novels ever written, Naked Lunch is a cultural landmark, now in a restored edition incorporating Burroughs' notes on the text, alternate drafts and outtakes from the original.",
                CategoryId = 3,
                ImageUrl = "Naked_lunch.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 9,
                Title = "Orlando",
                Author = "Virginia Woolf",
                Price = 30.95M,
                Description = "His longing for passion, adventure and fulfilment takes him out of his own time. Chasing a dream through the centuries, he bounds from Elizabethan England and imperial Turkey to the modern world. Will he find happiness with the exotic Russian Princess Sasha? Or is the dashing explorer Shelmerdine the ideal man? And what form will Orlando take on the journey - a nobleman, traveller, writer? Man or... woman?",
                CategoryId = 7,
                ImageUrl = "Orlando.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 10,
                Title = "The Picture of Dorian Grey",
                Author = "Oscar Wilde",
                Price = 39.95M,
                Description = "Tells the story of Dorian Gray, a beautiful yet corrupt man. When he wishes that a perfect portrait of himself would bear the signs of ageing in his place, the picture becomes his hideous secret, as it follows Dorian's own downward spiral into cruelty and depravity.",
                CategoryId = 1,
                ImageUrl = "Picture_of_dorian_gray.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 11,
                Title = "Pride and prejudice",
                Author = "Jane Austin",
                Price = 35.95M,
                Description = "Pride and Prejudice, which opens with one of the most famous sentences in English Literature, is an ironic novel of manners. In it the garrulous and emptyheaded Mrs Bennet has only one aim - that of finding a good match for each of her five daughters. In this she is mocked by her cynical and indolent husband. With its wit, its social precision and, above all, its irresistible heroine, Pride and Prejudice has proved one of the most enduringly popular novels in the English language.",
                CategoryId = 3,
                ImageUrl = "Pride_and_prejudice.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookId = 12,
                Title = "The Outsider",
                Author = "Albert Camus",
                Price = 36.95M,
                Description = "In The Outsider (1942), his classic existentialist novel, Camus explores the alienation of an individual who refuses to conform to social norms. Meursault, his anti-hero, will not lie. When his mother dies, he refuses to show his emotions simply to satisfy the expectations of others. And when he commits a random act of violence on a sun-drenched beach near Algiers, his lack of remorse compounds his guilt in the eyes of society and the law. Yet he is as much a victim as a criminal.",
                CategoryId = 2,
                ImageUrl = "The_Outsider.jpg",
                InStock = true,
                IsBookOfTheWeek = false,
            });


        }
    
}
}
