namespace VideoRentalStore.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VideoRentalStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VideoRentalStoreDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VideoRentalStore.Models.VideoRentalStoreDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            
            context.Customers.RemoveRange(context.Customers);
            context.RentalRecords.RemoveRange(context.RentalRecords);
            context.Medias.RemoveRange(context.Medias);
            
            IList<Customer> customers = new List<Customer>();
            // add customer #1
            customers.Add(new Customer() {
                FirstName = "John",
                LastName = "Doe",
                Address = "1005 1st Ave, Montreal, Quebec",
                PhoneNumber = "222-333-4444",
                RentalRecords = new List<RentalRecord>()
                {
                    new RentalRecord()
                    {
                        RentalDate = DateTime.Now.AddDays(-3),
                        RentedMedias = new List<Media>()
                        {
                            new Media()
                            {
                                Title = "Gone with the wind",
                                Type = "Movie",
                                ProductionYear = 1988
                            },
                            new Media()
                            {
                                Title = "Departed",
                                Type = "Movie",
                                ProductionYear = 2000
                            },
                            new Media()
                            {
                                Title = "Pride",
                                Type = "Music",
                                ProductionYear = 1998
                            }
                        }
                    },
                    new RentalRecord()
                    {
                        RentalDate = DateTime.Now.AddDays(-1),
                        RentedMedias = new List<Media>()
                        {
                            new Media()
                            {
                                Title = "Jurasic Park",
                                Type = "Movie",
                                ProductionYear = 1988
                            },
                            new Media()
                            {
                                Title = "Going home",
                                Type = "Movie",
                                ProductionYear = 2000
                            },
                            new Media()
                            {
                                Title = "Batman",
                                Type = "Movie",
                                ProductionYear = 1998
                            }
                        }
                    }
                }
            });
            
            // add customer #2
            customers.Add(new Customer()
            {
                FirstName = "Justin",
                LastName = "Trudeau",
                Address = "2005 2st Ave, Ottawa, Ontario",
                PhoneNumber = "555-666-7777",
                RentalRecords = new List<RentalRecord>()
                {
                    new RentalRecord()
                    {
                        RentalDate = DateTime.Now.AddDays(-5),
                        RentedMedias = new List<Media>()
                        {
                            new Media()
                            {
                                Title = "Montreal Fashion Show",
                                Type = "TV Show",
                                ProductionYear = 1976
                            },
                            new Media()
                            {
                                Title = "Spider Man",
                                Type = "Movie",
                                ProductionYear = 2002
                            },
                            new Media()
                            {
                                Title = "Somebody that I used to know",
                                Type = "Music",
                                ProductionYear = 2005
                            }
                        }
                    },
                    new RentalRecord()
                    {
                        RentalDate = DateTime.Now.AddDays(-7),
                        RentedMedias = new List<Media>()
                        {
                            new Media()
                            {
                                Title = "Super Man",
                                Type = "Movie",
                                ProductionYear = 1988
                            },
                            new Media()
                            {
                                Title = "History of Canada",
                                Type = "Documentation",
                                ProductionYear = 2011
                            },
                            new Media()
                            {
                                Title = "Drive by train",
                                Type = "Music",
                                ProductionYear = 1999
                            }
                        }
                    },
                    new RentalRecord()
                    {
                        RentalDate = DateTime.Now.AddDays(-1),
                        RentedMedias = new List<Media>()
                        {
                            new Media()
                            {
                                Title = "Quebec today",
                                Type = "Documentation",
                                ProductionYear = 2013
                            },
                            new Media()
                            {
                                Title = "Beattle",
                                Type = "CD",
                                ProductionYear = 1965
                            }
                        }
                    }
                }
            });

            context.Customers.AddRange(customers);
            base.Seed(context);
        }
    }
}
