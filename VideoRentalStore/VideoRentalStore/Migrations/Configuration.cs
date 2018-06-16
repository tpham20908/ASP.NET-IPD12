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
                                Title = "Movie1",
                                Type = "Movie",
                                ProductionYear = 1988
                            },
                            new Media()
                            {
                                Title = "Movie2",
                                Type = "Movie",
                                ProductionYear = 2000
                            },
                            new Media()
                            {
                                Title = "Music1",
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
                                Title = "Movie1001",
                                Type = "Movie",
                                ProductionYear = 1988
                            },
                            new Media()
                            {
                                Title = "Movie1002",
                                Type = "Movie",
                                ProductionYear = 2000
                            },
                            new Media()
                            {
                                Title = "Movie1003",
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
                                Title = "Show1001",
                                Type = "TV Show",
                                ProductionYear = 1976
                            },
                            new Media()
                            {
                                Title = "Movie1005",
                                Type = "Movie",
                                ProductionYear = 2002
                            },
                            new Media()
                            {
                                Title = "Music1002",
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
                                Title = "Movie1006",
                                Type = "Movie",
                                ProductionYear = 1988
                            },
                            new Media()
                            {
                                Title = "DocumentationTitle1001",
                                Type = "Documentation",
                                ProductionYear = 2011
                            },
                            new Media()
                            {
                                Title = "MusicTitle1003",
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
                                Title = "DocumentationTitle1002",
                                Type = "Documentation",
                                ProductionYear = 2013
                            },
                            new Media()
                            {
                                Title = "MusicTitle1003",
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
