using eTickets.Data.Enums;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name="Cinema 1",
                            LogoUrl="http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description="Description 1"
                        },
                        new Cinema()
                        {
                            Name="Cinema 2",
                            LogoUrl="http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description="Description 2"
                        },
                        new Cinema()
                        {
                            Name="Cinema 3",
                            LogoUrl="http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description="Description 3"
                        },
                        new Cinema()
                        {
                            Name="Cinema 4",
                            LogoUrl="http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description="Description 4"
                        },
                        new Cinema()
                        {
                            Name="Cinema 5",
                            LogoUrl="http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description="Description 5"
                        }
                    }

                        );
                    context.SaveChanges();
                }


                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() {
                    new Actor()
                    {
                        FullName="Fullname 1",
                        Bio="Bio 1",
                        ProfilePictureUrl="http://dotnethow.net/images/actors/actor-1.jpeg"
                    },
                    new Actor()
                    {
                        FullName="Fullname 2",
                        Bio="Bio 2",
                        ProfilePictureUrl="http://dotnethow.net/images/actors/actor-2.jpeg"
                    },
                    new Actor()
                    {
                        FullName="Fullname 3",
                        Bio="Bio 3",
                        ProfilePictureUrl="http://dotnethow.net/images/actors/actor-3.jpeg"
                    },
                    new Actor()
                    {
                        FullName="Fullname 4",
                        Bio="Bio 4",
                        ProfilePictureUrl="http://dotnethow.net/images/actors/actor-4.jpeg"
                    },
                    new Actor()
                    {
                        FullName="Fullname 5",
                        Bio="Bio 5",
                        ProfilePictureUrl="http://dotnethow.net/images/actors/actor-5.jpeg"
                    },

                    }); context.SaveChanges();
                }


                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>() {
                        new Producer()
                        {
                            FullName="Producer 1",
                            Bio= "Bio 1",
                            ProfilePictureUrl="http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                         new Producer()
                        {
                            FullName="Producer 1",
                            Bio= "Bio 1",
                            ProfilePictureUrl="http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 2",
                            Bio= "Bio 2",
                            ProfilePictureUrl="http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 3",
                            Bio= "Bio 3",
                            ProfilePictureUrl="http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 4",
                            Bio= "Bio 4",
                            ProfilePictureUrl="http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName="Producer 5",
                            Bio= "Bio 5",
                            ProfilePictureUrl="http://dotnethow.net/images/producers/producer-5.jpeg"
                        }

                    });
                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>() {
                    new Movie()
                    {
                        Name="Name 1",
                        Description="Description 1",
                        Price=99.99,
                        ImageUrl="http://dotnethow.net/images/movies/movie-1.jpeg",
                        StartDate=DateTime.Now,
                        EndDate=DateTime.Now.AddDays(5),
                        CinemaId=4,
                        ProducerID=4,
                        MovieCategory=MovieCategory.Action
                    },
                                        new Movie()
                    {
                        Name="Name 2",
                        Description="Description 2",
                        Price=99.99,
                        ImageUrl="http://dotnethow.net/images/movies/movie-2.jpeg",
                        StartDate=DateTime.Now,
                        EndDate=DateTime.Now.AddDays(5),
                        CinemaId=2,
                        ProducerID=2,
                        MovieCategory=MovieCategory.Action
                    },
                    new Movie()
                    {
                        Name="Name 3",
                        Description="Description 3",
                        Price=99.99,
                        ImageUrl="http://dotnethow.net/images/movies/movie-3.jpeg",
                        StartDate=DateTime.Now,
                        EndDate=DateTime.Now.AddDays(5),
                        CinemaId=3,
                        ProducerID=3,
                        MovieCategory=MovieCategory.Action
                    },
                    new Movie()
                    {
                        Name="Name 4",
                        Description="Description 4",
                        Price=99.99,
                        ImageUrl="http://dotnethow.net/images/movies/movie-4.jpeg",
                        StartDate=DateTime.Now,
                        EndDate=DateTime.Now.AddDays(5),
                        CinemaId=4,
                        ProducerID=4,
                        MovieCategory=MovieCategory.Action
                    },
                    new Movie()
                    {
                        Name="Name 5",
                        Description="Description 5",
                        Price=99.99,
                        ImageUrl="http://dotnethow.net/images/movies/movie-5.jpeg",
                        StartDate=DateTime.Now,
                        EndDate=DateTime.Now.AddDays(5),
                        CinemaId=5,
                        ProducerID=5,
                        MovieCategory=MovieCategory.Action
                    }
                    });
                    context.SaveChanges();
                }

                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>() {
                    new Actor_Movie()
                    {
                        ActorId=1,
                        MovieId=1,
                    },
                    new Actor_Movie()
                    {
                        ActorId=2,
                        MovieId=2,
                    },
                    new Actor_Movie()
                    {
                        ActorId=3,
                        MovieId=3,
                    },
                    new Actor_Movie()
                    {
                        ActorId=4,
                        MovieId=4,
                    },
                    new Actor_Movie()
                    {
                        ActorId=5,
                        MovieId=5,
                    },
                    new Actor_Movie()
                    {
                        ActorId=5,
                        MovieId=1,
                    },
                    new Actor_Movie()
                    {
                        ActorId=1,
                        MovieId=2,
                    },
                    new Actor_Movie()
                    {
                        ActorId=1,
                        MovieId=3,
                    },
                    new Actor_Movie()
                    {
                        ActorId=1,
                        MovieId=4,
                    },
                    new Actor_Movie()
                    {
                        ActorId=1,
                        MovieId=5,
                    }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
