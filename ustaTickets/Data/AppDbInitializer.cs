using System;
using ustaTickets.Models;
using static Humanizer.On;

namespace ustaTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinema.Any())
                {
                    context.Cinema.AddRange(new List<Cinema>()
                        {
                        new Cinema()
                        {
                          Name= "Walt Disney Studios",
                          Logo= "http://localhost/img/cinema/disney.png",
                          Description="The Walt Disney Studios es un estudio de cine estadounidense, es una de las cuatro divisiones comerciales de The Walt Disney Company.1​ El estudio, es uno de los más importantes del mundo ya que es considerado el número uno de los \"Cinco Grandes\" y es mejor conocido por sus divisiones cinematográficas multifacéticas, tiene su sede en el estudio homónimo de The Walt Disney Studios en Burbank, California. Fundado en 1923, es el cuarto más antiguo entre los principales estudios.2​"
                        },
                        new Cinema()
                        {
                          Name= "Warner Bros. Entertainment",
                          Logo= "http://localhost/img/cinema/wb.jpg",
                          Description="Fundada en 1923, tiene operaciones en cine, televisión y videojuegos y es uno de los principales estudios de cinematografía estadounidenses, así como miembro de la Motion Picture Association of America"
                        },
                        new Cinema(){
                            Name="Sony Pictures",
                            Logo="http://localhost/img/cinema/sony.png",
                            Description="es una distribuidora y productora cinematográfica estadounidense subsidiaria de Sony Corporation, un conglomerado de tecnología multinacional y medios de comunicación con sede en Japón. En 2010 se informó que sus ventas habían sido de $7200 millones.",
                        },
                        new Cinema(){
                        Name="Paramount Global",
                        Logo="http://localhost/img/cinema/permanout.jpg",
                        Description="es una compañía productora y distribuidora de cine, con sede en Hollywood (California). Es propiedad de Paramount Global y anteriormente de Gulf+Western. Fue fundada el 8 de mayo de 1912."
                        }

                    });
                    context.SaveChanges();
                }
                if (!context.Director.Any())
                {
                    context.Director.AddRange(new List<Director>()
                        {
                        new Director()
                        {
                          ProfilePictureURL= "http://localhost/img/director/Batman/MattReeves.jpg",
                          FullName= "Matt Reeves",
                          bio="Matthew George Matt Reeves (nacido el 27 de abril de 1966 en Rockville Center, Nueva York, EE. UU.) es un guionista, director y productor estadounidense. Comenzó a hacer películas a los ocho años, dirigiendo a amigos y usando una cámara de cuerda. Reeves se hizo amigo del cineasta J.J. Abrams cuando ambos tenían 13 años y hacían cortometrajes juntos.​"

                        }, new Director()
                        {
                          ProfilePictureURL=  "http://localhost/img/director/DoctorStrange/SamRaimi.jpg",
                          FullName= "Sam Raimi",
                          bio="Sam Raimi (Royal Oak, 23 de octubre de 1959) es un director, productor y guionista estadounidense. A Raimi se lo reconoce mayormente por su trabajo en la dirección de la primera trilogía del personaje Spider-Man, estrenada entre los años 2000's. Además también por su labor como director con filmes de terror de bajo presupuesto como la trilogía de The Evil Dead, el cual fue uno de sus primeros proyectos.​"

                        }, new Director()
                        {
                          ProfilePictureURL=  "http://localhost/img/director/Guardines/HarouSoto.jpg",
                          FullName= "Haruo Sotozaki",
                          bio="​No tenemos una biografía de Haruo Sotozaki."

                        }, new Director()
                        {
                          ProfilePictureURL=  "http://localhost/img/director/Jujutsu/Sunghoo.jpg",
                          FullName= "Sunghoo Park",
                          bio="Sunghoo Park (Kanji: 朴性厚, Hangul: 박성후) es un director, director de animación y animador de Corea del Sur. Es principalmente conocido por dirigir The God of High School y Jujutsu Kaisen."

                        }, new Director()
                        {
                          ProfilePictureURL=  "http://localhost/img/director/Jurussic/ColinTrevorrow.jpg",
                          FullName= "Colin Trevorrow",
                          bio="​Colin T. Trevorrow (Estados Unidos: /trəˈvɑːroʊ/; nacido el 13 de septiembre de 1976) es un director de cine y guionista estadounidense. Dirigió la película independiente Safety Not Guaranteed (2012) y el éxito de taquilla Jurassic World (2015), y también coescribió el guión de Jurassic World y su secuela de 2018."

                        }, new Director()
                        {
                          ProfilePictureURL=  "http://localhost/img/director/Light/AngusMacLane.jpg",
                          FullName= "Angus MacLane",
                          bio="​Angus MacLane es un director, animador, guionista y actor de doblaje estadounidense que actualmente trabaja en Pixar. Dirigió los cortometrajes BURN-E, Small Fry y el especial de televisión Toy Story of Terror! Codirigió la película Finding Dory (2016)"

                        }, new Director()
                        {
                          ProfilePictureURL=  "http://localhost/img/director/Mor/DanielEspinosa.jpg",
                          FullName= "Daniel Espinosa",
                          bio="Jorge Daniel Espinosa (nacido el 23 de marzo de 1977) es un director de cine sueco de Trångsund, Estocolmo de origen chileno. Asistió a la Escuela Nacional de Cine de Dinamarca y se graduó en 2001. Su tercer largometraje, Dinero fácil, fue la película sueca con más entradas en Suecia en 2010."

                        }, new Director()
                        {
                          ProfilePictureURL=  "http://localhost/img/director/ResidentEvil/JohannesRoberts.jpg",
                          FullName= "Johannes Roberts",
                          bio="​Johannes Roberts (nacido el 24 de mayo de 1976 en Cambridge, Inglaterra) es un escritor y director británico que ha trabajado principalmente en el género de terror. Es mejor conocido por su película de terror sobrenatural The Other Side of the Door (2016), los thrillers de tiburones 47 Meters Down (2017)"

                        }, new Director()
                        {
                          ProfilePictureURL=  "http://localhost/img/director/ThorLoveandThunder/taikaWaititi.jpg",
                          FullName= "Taika Waititi",
                          bio="Taika David Waititi (16 de agosto de 1975), también conocido como Taika Cohen, es un director, escritor, pintor, comediante y actor neozelandés.​"

                        }, new Director()
                        {
                          ProfilePictureURL=  "http://localhost/img/director/TopGunMaverick/JosephK.jpg",
                          FullName= "Joseph Kosinski",
                          bio="Joseph Kosinski (nacido el 3 de mayo de 1974) es un director de cine estadounidense mejor conocido por las películas de ciencia ficción \"Tron: Legacy\" (2010) y \"Oblivion\" (2013), el drama y suspenso \"Only the Brave\" (2017) , y el thriller de acción \"Top Gun: Maverick\" (2022). Su trabajo anterior ha sido principalmente en el campo de los comerciales de televisión CGI, más notablemente sus comerciales de 2007 para los videojuegos Halo 3 y Gears of War.​"

                        }


                    });
                    context.SaveChanges();
                }
                //Actor
                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new List<Actor>()
                        {
                        new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Batman/JohnTurturro.jpg",
                          FullName= "John Turturro",
                          Bio="John Michael Turturro (Brooklyn, Nueva York; 28 de febrero de 1957) es un actor y director estadounidense-italiano.2​ Su carrera abarca cuatro décadas durante las cuales ha actuado en más de ochenta películas en roles cómicos y dramáticos, además ha trabajado ocasionalmente en el teatro y la televisión y dirigido cinco largometrajes. ",

                        },
                        new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Batman/PaulDano.jpg",
                          FullName= "Paul Dano",
                          Bio="Paul Franklin Dano (19 de junio de 1984) es un actor, director, guionista y músico estadounidense. Ha trabajado, entre otras, en las películas There Will Be Blood, Little Miss Sunshine, Ruby Sparks",

                        },
                        new Actor()
                        {

                          ProfilePictureURL= "http://localhost/img/actors/Batman/RobertPattinson.jpg",
                          FullName= "Robert Pattinson",
                          Bio="Robert Thomas Pattinson (13 de mayo de 1986) es un actor, modelo, productor y cantante británico.",

                        } ,new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/DoctorStrange/BenedictCumberbatch.jpg",
                          FullName= "Benedict Cumberbatch",
                          Bio="Benedict Timothy Carlton Cumberbatch (19 de julio de 1976) es un actor inglés de cine, televisión y teatro. Sus papeles más aclamados incluyen: Stephen Hawking en el drama de la BBC «Hawking» (2004); William Pitt en la película histórica «Amazing Grace» (2006)",

                        }
                        ,new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/DoctorStrange/BenedictWong.jpg",
                            FullName= "Benedict Wong",
                            Bio="Benedict Wong (3 de junio de 1971)​ es un actor británico conocido por interpretar a Kublai Khan en la serie de Netflix Marco Polo (2014), a Bruce Ng en The Martian (2015) y a Wong en la adaptación cinematográfica de Doctor Strange (2016) de Marvel. Wong no sólo ha tenido una ilustre carrera en el cine y la televisión, sino también en teatro.",
                        }
                        ,new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/DoctorStrange/ChiwetelEjiofor.jpg",
                            FullName= "Chiwetel Ejiofor",
                            Bio="Chiwetel Ejiofor (10 de julio de 1977) es un actor y director británico que estuvo nominado al Óscar por su interpretación en la película 12 años de esclavitud.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/DoctorStrange/ElizabethOlsen.jpg",
                            FullName= "Elizabeth Olsen",
                            Bio="Elizabeth Chase Olsen (16 de febrero de 1989), hermana de Mary-Kate y Ashley Olsen. Apareció en las películas de sus hermanas mayores How the West Was Fun en 1994 y The Adventures of Mary-Kate & Ashley",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/GuardianesdelaNoche/AkariKito.jpg",
                            FullName= "Akari Kito",
                            Bio="Akari Kito (鬼頭 明里, Kitō Akari, 16 de octubre de 1994) es una actriz de voz japonesa afiliada a Pro-Fit. Debutó en 2014 y actuó en su primer papel principal en Time Bokan 24 en 2016. En octubre de 2019 hizo su debut como cantante con Pony Canyon.​",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/GuardianesdelaNoche/HiroShimono.jpg",
                            FullName= "Hiro Shimono",
                            Bio="Hiro Shimono es un actor de voz y cantante japonés afiliado a I'm Enterprise. Sus papeles notables incluyen a Keima Katsuragi en The World God Only Knows, Connie Springer en Attack on Titan, Nai en Karneval, Ayato Kamina en RahXephon.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/GuardianesdelaNoche/NatsukiHanae.jpg",
                            FullName= "Natsuki Hanae",
                            Bio="Natsuki Hanae es un actor de doblaje japonés de la prefectura de Kanagawa. Está afiliado a Across Entertainment. En 2015, ganó un premio en los 9th Seiyuu Awards como uno de los mejores recién llegados masculinos.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/JujutsuKaisen0/KanaHanazawa.jpg",
                            FullName= "Kana Hanazawa",
                            Bio="Kana Hanazawa is a Japanese voice actress affiliated with the Office Osawa talent agency. In 2012 she made her debut as a singer.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/JujutsuKaisen0/KokiUchiyama.jpg",
                            FullName= "Koki Uchiyama",
                            Bio="Koki Uchiyama is a Japanese actor and voice actor.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/JujutsuKaisen0/MegumiOgata.jpg",
                            FullName= "Megumi Ogata",
                            Bio="Megumi Ogata es una actriz de voz y cantante japonesa del área metropolitana de Tokio. Como cantante, se hace llamar em:óu. Asistió a la Universidad de Tokai , pero se fue por falta de interés.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/JujutsuKaisen0/YuichiNakamura.jpg",
                            FullName= "Yuichi Nakamura",
                            Bio="Yuichi Nakamura es un actor de doblaje japonés. Anteriormente afiliado a Sigma Seven y actualmente a Intention. Prestó su voz a Gray Fullbuster en Fairy Tail, Gai Tsutsugami en Guilty Crown, Tatsuya Shiba en The Irregular at Magic High School, Karamatsu en Osomatsu-san, Alto Saotome en Macross Frontier, Tomoya Okazaki en Clannad",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Jurasic/BryceDallasHoward.jpg",
                            FullName= "Bryce Dallas Howard",
                            Bio="Bryce Dallas Howard (¡2 de marzo de 1981) es una actriz, guionista y directora estadounidense, hija del director Ron Howard. Hizo su debut como actriz bajo la dirección de su padre en la película Parenthood en 1989 y pasó a tener pequeños papeles en películas y hacer apariciones en el escenario en los años siguientes.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Jurasic/ChrisPratt.jpg",
                            FullName= "Chris Pratt",
                            Bio="Christopher Michael Pratt (21 de junio de 1979), conocido simplemente como Chris Pratt, es un actor, actor de voz y productor estadounidense. Aunque nació en Virginia, creció en la ciudad de Lake Stevens y desde temprana edad tuvo problemas con su sobrepeso. Tras terminar la secundaria en 1997, abandonó sus estudios para mudarse a Maui (Hawái), donde vivió sin un hogar hasta que fue descubierto por la actriz Rae Dawn Chong mientras trabajaba como mesero a los 19 años.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Jurasic/JeffGoldblum.jpg",
                            FullName= "Jeff Goldblum",
                            Bio="Jeffrey Lynn Goldblum (22 de octubre de 1952), más conocido como Jeff Goldblum, es un actor y músico estadounidense. Su carrera comenzó a mediados de la década de 1970 y desde entonces se ha destacado en películas taquilleras como La mosca (1986), Parque Jurásico (1993), Independence Day (1996), El mundo perdido (1997), Jurassic World: El reino caído (2018), entre otras. ",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Jurasic/LauraDern.jpg",
                            FullName= "Laura Dern",
                            Bio="Fue nominada al Óscar a la mejor actriz por su trabajo en la película Rambling Rose y al Óscar a la mejor actriz de reparto por Alma salvaje, y fue ganadora como mejor actriz de reparto por Historia de un matrimonio. Por Ya no somos dos recibió el premio a la mejor actriz de reparto de la Boston Society of Film Critics. ",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Lightyear/ChrisEvans.jpg",
                            FullName= "Chris Evans",
                            Bio="Christopher Robert «Chris» Evans (nacido el 13 de junio de 1981) es un actor y cineasta americano. Evans es conocido por su papel de superhéroe como Capitán América en el universo Marvel, y como la Antorcha humana en Los 4 Fantásticos y su secuela Los 4 Fantásticos y Silver Surfer. En 2014, hizo su debut como director con el drama romántico «Antes de que te vayas».",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Lightyear/JamesBrolin.jpg",
                            FullName= "James Brolin",
                            Bio="James Brolin (nacido el 18 de julio de 1940) es un actor, productor y director estadounidense, mejor conocido por sus papeles en telenovelas, películas, comedias de situación y televisión. Es el padre del actor Josh Brolin y esposo de la cantante y actriz Barbra Streisand.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Lightyear/KekePalmer.jpg",
                            FullName= "Keke Palmer",
                            Bio="Lauren Keyana Keke Palmer (nacida el 26 de agosto de 1993) es una actriz, cantante y personalidad televisiva estadounidense. Conocida por interpretar papeles protagónicos y de personajes en producciones de comedia dramática, ha recibido un premio Primetime Emmy, cinco premios NAACP Image y nominaciones para un premio Daytime Emmy y un premio Screen Actors Guild. Fue incluida en la lista de la revista Time de las personas más influyentes del mundo en 2019.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Lightyear/TaikaWaititi.jpg",
                            FullName= "Taika Waititi",
                            Bio="Taika David Waititi (16 de agosto de 1975), también conocido como Taika Cohen, es un director, escritor, pintor, comediante y actor neozelandés.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Morbius/AdriaArjona.jpg",
                            FullName= "Adria Arjona",
                            Bio="Adria Arjona Torres es una actriz puertorriqueña y guatemalteca, conocida por sus papeles en las series de televisión True Detective y Person of Interest. Es la hija mayor del cantautor Ricardo Arjona y de la modelo Leslie Torres.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Morbius/JaredLeto.jpg",
                            FullName= "Jared Leto",
                            Bio="Jared Joseph Leto (nacido el 26 de diciembre de 1971) es un actor y músico estadounidense. Luego de comenzar su carrera con apariciones en televisión a principios de la década de 1990, logró el reconocimiento por su papel de Jordan Catalano en la serie de televisión My So-Called Life (1994). Hizo su debut cinematográfico en How to Make an American Quilt (1995) y recibió elogios de la crítica por su actuación en Prefontaine (1997).",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/Morbius/MattSmith.jpg",
                            FullName= "Matt Smith",
                            Bio="Matthew Robert «Matt» Smith es un actor de televisión británico, más conocido por su papel como la Undécima encarnación del Doctor en la serie de televisión británica Doctor Who y a Philip Mountbatten, Duque de Edimburgo, en la serie Crown.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/ResidentEvil/AvanJogia.jpg",
                            FullName= "Avan Jogia",
                            Bio="Avan Jogia (nacido el 9 de febrero de 1992) es un actor y cantante canadiense mejor conocido por interpretar a Beck Oliver en Victorious. Aunque es de Vancouver, pasa la mayor parte de su tiempo entre Vancouver y Los Ángeles.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/ResidentEvil/HannahJohn.jpg",
                            FullName= "Hannah John-Kamen",
                            Bio="Hannah Dominique E. John-Kamen (6 de septiembre de 1989)​, más conocida como Hannah John-Kamen, es una actriz británica.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/ResidentEvil/KayaScodelario.jpg",
                            FullName= "Kaya Scodelario",
                            Bio="Kaya Rose Humphrey Scodelario (13 de marzo de 1992), más conocida como Kaya Scodelario, es una actriz británica de ascendencia italo-brasileña e inglesa. Entre sus papeles, destacan el de Effy Stonem en la serie británica, Skins, Teresa Agnes en la trilogía de películas, Maze Runner, Kat Baker en la serie de Netflix, Spinning Out, y Carina Smyth en la película Pirates of the Caribbean",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/ResidentEvil/NealMcDonough.jpg",
                            FullName= "Neal McDonough",
                            Bio="Neal McDonough (13 de febrero de 1966) es un actor estadounidense. Conocido por sus participaciones antagónicas en las películas en las que actúa.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/ThorLoveandThunder/ChrisHemsworth.jpg",
                            FullName= "Chris Hemsworth",
                            Bio="Chris Hemsworth nació en Melbourne, Australia, de Leonie (van Os), profesora de inglés, y Craig Hemsworth, un consejero de servicios sociales. Sus hermanos son los actores Liam Hemsworth y Luke Hemsworth. Es de ascendencia holandesa (de su abuelo materno inmigrante), irlandés, inglés, escocés y alemán. Su tío, por matrimonio, fue Rod Ansell, el hombre de monte que inspiró la película Cocodrilo Dundee (1986).",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/ThorLoveandThunder/NataliePortman.jpg",
                            FullName= "Natalie Portman",
                            Bio="Natalie Portman es la primera persona nacida en la década de 1980 que ganó el Premio de la Academia a la Mejor Actriz (por Cisne negro (2010)).",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/TopGun/JenniferConnelly.jpg",
                            FullName= "Jennifer Connelly",
                            Bio="Jennifer Lynn Connelly (12 de diciembre de 1970) es una actriz estadounidense ganadora del Óscar y el Globo de Oro por su papel en A Beautiful Mind. Asimismo, es reconocida por sus interpretaciones en películas como Labyrinth (1986), Requiem for a Dream (2000), Dark City (1998), Hulk (2003), Casa de arena y niebla (2003) y Diamante de sangre (2006).",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/TopGun/LweisPullman.jpg",
                            FullName= "Lewis Pullman",
                            Bio="Actor estadounidense.",
                        },new Actor()
                        {
                          ProfilePictureURL= "http://localhost/img/actors/TopGun/TomCruise.jpg",
                            FullName= "Tom Cruise",
                            Bio="Tom es el único hijo (entre cuatro hijos) de padres nómadas, Mary Lee (Pfeiffer), maestra de educación especial, y Thomas Cruise Mapother III, ingeniero eléctrico. Sus padres eran de Louisville, Kentucky, y él tiene ascendencia alemana, irlandesa e inglesa. Young Tom pasó su infancia siempre en movimiento, y cuando tenía 14 años había asistido a 15 escuelas diferentes en los Estados Unidos y Canadá. Finalmente se estableció en Glen Ridge, Nueva Jersey, con su madre y su nuevo esposo. ",
                        }

                    });
                    context.SaveChanges();
                }
                //Movie
                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new List<Movie>()
                        {
                        new Movie()
                        {
                         Name= "The Batman",
                         Description="Cuando un asesino se dirige a la élite de Gotham con una serie de maquinaciones sádicas, un rastro de pistas crípticas envía Batman a una investigación en los bajos fondos. A medida que las pruebas comienzan a acercarse a su casa y se hace evidente la magnitud de los planes del autor, Batman debe forjar nuevas relaciones, desenmascarar al culpable y hacer justicia al abuso de poder y la corrupción que durante mucho tiempo han asolado Gotham City.",
                         Price= 8000.0,
                         ImageURL="http://localhost/img/movies/Batman/batman.jpg",
                         DirectorId=1,
                         CinemaId=1,
                         StartTime= DateTime.Now.AddDays(-30),
                         EndTime= DateTime.Now.AddDays(-10),
                         MovieCategory=Enum.MovieCategory.Dc,

                        }, new Movie()
                        {
                         Name= "Doctor Strange en el multiverso de la locura",
                         Description="Viaja a lo desconocido con el Doctor Strange, quien, con la ayuda de tanto antiguos como nuevos aliados místicos, recorre las complejas y peligrosas realidades alternativas del multiverso para enfrentarse a un nuevo y misterioso adversario.",
                         Price= 5000.0,
                         ImageURL="http://localhost/img/movies/DoctorStrange/doctor.jpg",
                         DirectorId=2,
                         CinemaId=2,
                         StartTime= DateTime.Now.AddDays(-50),
                         EndTime= DateTime.Now.AddDays(-22),
                         MovieCategory=Enum.MovieCategory.Marvel,

                        }, new Movie()
                        {
                         Name= "Guardianes de la Noche: Tren infinito",
                         Description="Tanjiro y sus compañeros se unen al Pilar de las Llamas Kyojuro Rengoku para investigar una misteriosa serie de desapariciones que han ocurrido dentro del “Tren Infinito”. Poco saben que Enmu, uno de los miembros de las Doce Lunas Demoníacas, también está a bordo y les ha preparado una trampa.",
                         Price= 12000.0,
                         ImageURL="http://localhost/img/movies/GuardianesdelaNoche/guardianes.jpg",
                         DirectorId=3,
                         CinemaId=3,
                         StartTime= DateTime.Now.AddDays(-40),
                         EndTime= DateTime.Now.AddDays(-32),
                         MovieCategory=Enum.MovieCategory.Anime,

                        },new Movie()
                        {
                         Name= "Jujutsu Kaisen 0",
                         Description="Yuta Okkotsu es un nervioso estudiante de instituto que sufre un grave problema: su amiga de la infancia Rika se ha convertido en una maldición y no le deja en paz. Como Rika no es una maldición cualquiera, su situación es percibida por Satoru Gojo, un profesor del instituto Jujutsu, una escuela donde los exorcistas noveles aprenden a combatir las maldiciones. ",
                         Price= 10000.0,
                         ImageURL="http://localhost/img/movies/JujutsuKaisen0/jujutsu.jpg",
                         DirectorId=4,
                         CinemaId=2,
                         StartTime= DateTime.Now.AddDays(-70),
                         EndTime= DateTime.Now.AddDays(-34),
                         MovieCategory=Enum.MovieCategory.Anime,

                        },new Movie()
                        {
                         Name= "Jurassic World: Dominion",
                         Description="Cuatro años después de la destrucción de Isla Nublar, los dinosaurios conviven – y cazan – con los seres humanos en todo el mundo. Este frágil equilibrio cambiará el futuro y decidirá, de una vez por todas, si los seres humanos seguirán en la cúspide de los depredadores en un planeta que comparten con los animales más temibles de la creación.",
                         Price= 4500.0,
                         ImageURL="http://localhost/img/movies/Jurasic/jurassic.jpg",
                         DirectorId=5,
                         CinemaId=4,
                         StartTime= DateTime.Now.AddDays(-55),
                         EndTime= DateTime.Now.AddDays(-41),
                         MovieCategory=Enum.MovieCategory.Documentary,

                        },new Movie()
                        {
                         Name= "Lightyear",
                         Description="Atrapado en un planeta hostil a 4,2 millones de años luz de la Tierra junto a su comandante y su tripulación, Buzz Lightyear intenta encontrar la manera de volver a casa a través del espacio y el tiempo. Pero la llegada de Zurg, una presencia imponente con un ejército de robots despiadados y una agenda misteriosa, complica aún más las cosas y pone en peligro la misión.",
                         Price= 7000.0,
                         ImageURL="http://localhost/img/movies/Lightyear/lightyear.jpg",
                         DirectorId=6,
                         CinemaId=3,
                         StartTime= DateTime.Now.AddDays(-20),
                         EndTime= DateTime.Now.AddDays(-2),
                         MovieCategory=Enum.MovieCategory.Anime,

                        },new Movie()
                        {
                         Name= "Morbius",
                         Description="Peligrosamente enfermo de un extraño trastorno sanguíneo, y determinado a salvar a otras personas que padecen su mismo destino, el doctor Morbius intenta una apuesta desesperada. Lo que en un principio parece ser un éxito radical, pronto se revela como un remedio potencialmente peor que la enfermedad.",
                         Price= 6500.0,
                         ImageURL="http://localhost/img/movies/Morbius/morbius.jpg",
                         DirectorId=7,
                         CinemaId=3,
                         StartTime= DateTime.Now.AddDays(-32),
                         EndTime= DateTime.Now.AddDays(-12),
                         MovieCategory=Enum.MovieCategory.Dc,

                        },new Movie()
                        {
                         Name= "Resident Evil: Bienvenidos a Raccoon City",
                         Description="Nueva adaptación al cine de los videojuegos de Capcom. La que fue una pujante ciudad sede del gigante farmacéutico Umbrella Corporation, Raccoon City, es ahora un pueblo agonizante del Medio Oeste. El éxodo de la compañía dejó a la ciudad convertida en un erial… con un gran mal gestándose bajo la superficie. Cuando ese mal se desata, un grupo de supervivientes deben unirse para destapar la verdad detrás de Umbrella y sobrevivir a la noche.",
                         Price= 2000.0,
                         ImageURL="http://localhost/img/movies/ResidentEvil/resident.jpg",
                         DirectorId=8,
                         CinemaId=1,
                         StartTime= DateTime.Now.AddDays(-80),
                         EndTime= DateTime.Now.AddDays(-30),
                         MovieCategory=Enum.MovieCategory.Zombies,

                        },new Movie()
                        {
                         Name= "Thor: Love and Thunder",
                         Description="El Dios del Trueno emprende un viaje que no se parece en nada a lo que se ha enfrentado hasta ahora: una búsqueda de la paz interior. Pero el retiro de Thor se ve interrumpido por un asesino galáctico conocido como Gorr el Carnicero de Dioses. Para hacer frente a la amenaza, Thor solicita la ayuda de Valkiria, de Korg y de su ex novia Jane Foster que, para sorpresa de Thor, empuña su martillo mágico, Mjolnir, como la Poderosa Thor. ",
                         Price= 13000.0,
                         ImageURL="http://localhost/img/movies/ThorLoveandThunder/thor.jpg",
                         DirectorId=9,
                         CinemaId=2,
                         StartTime= DateTime.Now.AddDays(-10),
                         EndTime= DateTime.Now.AddDays(-1),
                         MovieCategory=Enum.MovieCategory.Marvel,

                        },new Movie()
                        {
                         Name= "Top Gun: Maverick",
                         Description="Después de más de 30 años de servicio como uno de los mejores aviadores de la Armada, Pete \"Maverick\" Mitchell se encuentra dónde siempre quiso estar, empujando los límites como un valiente piloto de prueba y esquivando el alcance en su rango, que no le dejaría volar emplazándolo en tierra.",
                         Price= 12500.0,
                         ImageURL="http://localhost/img/movies/TopGunMaverick/top.jpg",
                         DirectorId=10,
                         CinemaId=3,
                         StartTime= DateTime.Now.AddDays(-10),
                         EndTime= DateTime.Now.AddDays(-1),
                         MovieCategory=Enum.MovieCategory.Action,

                        }

                    });
                    context.SaveChanges();
                }
                //Actor_Movie
                if (!context.Actor_Movie.Any())
                {
                    context.Actor_Movie.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId =1
                        },new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId =1
                        },new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId =1
                        },new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId =2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId =2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId =2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId =2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 8,
                            MovieId =3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 9,
                            MovieId =3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 10,
                            MovieId =3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 11,
                            MovieId =4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 12,
                            MovieId =4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 13,
                            MovieId =4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 14,
                            MovieId =4
                        },
                        new Actor_Movie()
                        {
                            ActorId =15,
                            MovieId =5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 16,
                            MovieId =5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 17,
                            MovieId =5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 18,
                            MovieId =5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 19,
                            MovieId =6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 20,
                            MovieId =6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 21,
                            MovieId =6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 22,
                            MovieId =6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 23,
                            MovieId =7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 24,
                            MovieId =7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 25,
                            MovieId =7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 26,
                            MovieId =8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 27,
                            MovieId =8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 28,
                            MovieId =8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 29,
                            MovieId =8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 30,
                            MovieId =9
                        },
                        new Actor_Movie()
                        {
                            ActorId = 16,
                            MovieId =9
                        },
                        new Actor_Movie()
                        {
                            ActorId = 31,
                            MovieId =9
                        },
                        new Actor_Movie()
                        {
                            ActorId = 32,
                            MovieId =10
                        },
                        new Actor_Movie()
                        {
                            ActorId = 33,
                            MovieId =10
                        },
                        new Actor_Movie()
                        {
                            ActorId = 34,
                            MovieId =10
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
