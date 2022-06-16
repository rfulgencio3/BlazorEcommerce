using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
             new Product
             {
                 Id = 1,
                 Title = "The Silmarillion",
                 Description = $"The Silmarillion (Quenya: [silmaˈrilliɔn]) is a collection of mythopoeic stories by the English writer J. R. R. Tolkien, edited and published posthumously by his son Christopher Tolkien in 1977 with assistance from the fantasy author Guy Gavriel Kay.[T 1] The Silmarillion tells of Eä, a fictional universe that includes the Blessed Realm of Valinor, the once-great region of Beleriand, the sunken island of Númenor, and the continent of Middle-earth, where Tolkien's most popular works—The Hobbit and The Lord of the Rings—are set. After the success of The Hobbit, Tolkien's publisher Stanley Unwin requested a sequel, and Tolkien offered a draft of the stories that would later become The Silmarillion. Unwin rejected this proposal, calling the draft obscure and 'too Celtic', so Tolkien began working on a new story that eventually became The Lord of the Rings.",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/db/Silmarillion.png",
                 Price = 9.99M
             },
             new Product
             {
                 Id = 2,
                 Title = $"Star Wars Jedi: Fallen Order",
                 Description = "Star Wars Jedi: Fallen Order is an action-adventure video game developed by Respawn Entertainment and published by Electronic Arts. It was released for Windows, PlayStation 4 and Xbox One in November 2019, for Stadia in November 2020, and for the PlayStation 5 and Xbox Series X and Series S in June 2021. The story, set in the Star Wars universe five years after Star Wars: Episode III – Revenge of the Sith, follows Jedi Padawan Cal Kestis, who becomes a target of the Galactic Empire and is hunted throughout the galaxy by the Imperial Inquisition while attempting to complete his training, reconcile with his troubled past, and rebuild the fallen Jedi Order.",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Cover_art_of_Star_Wars_Jedi_Fallen_Order.jpg",
                 Price = 119.89M
             },
             new Product
             {
                 Id = 3,
                 Title = "Fight Club",
                 Description = $"Fight Club is a 1999 American film directed by David Fincher and starring Brad Pitt, Edward Norton, and Helena Bonham Carter. It is based on the 1996 novel of the same name by Chuck Palahniuk. Norton plays the unnamed narrator, who is discontented with his white-collar job. He forms a 'fight club' with soap salesman Tyler Durden (Pitt), and becomes embroiled in a relationship with a destitute woman, Marla Singer (Bonham Carter).",
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg",
                 Price = 1.78M
             }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(Products);
        }
    }
}
