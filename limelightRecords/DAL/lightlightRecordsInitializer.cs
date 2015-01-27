using limelightRecords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace limelightRecords.DAL
{
    public class limelightRecordsInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<limelightRecordsContext>
    {

        protected override void Seed(limelightRecordsContext context)
        {
            var artists = new List<limelightRecords.Models.Artist>
            {
            new Artist{ArtistName="Bassnectar",ArtistLocation="Los Angeles, CA",ArtistGenre="Electronic, Dubstep, Trip-Hop" ,SignDate=DateTime.Parse("2001-39-07"), BookCost=12000, CurrentlyAvailable="No", AgentID=3 },
            new Artist{ArtistName="Skrillex",ArtistLocation="San Diego, CA",ArtistGenre="Electronic, Dubstep, House" ,SignDate=DateTime.Parse("2005-09-02"), BookCost=18000, CurrentlyAvailable="No", AgentID=2 },
            new Artist{ArtistName="Pretty Lights",ArtistLocation="Denver, Colorado",ArtistGenre="Electronic, Dubstep, Trip-Hop, Hip Hop" ,SignDate=DateTime.Parse("2005-02-05"), BookCost=12000, CurrentlyAvailable="No", AgentID=3 },
            new Artist{ArtistName="The Roots",ArtistLocation="Philadelphia, PA",ArtistGenre="Hip Hop, Soul" ,SignDate=DateTime.Parse("2007-09-01"), BookCost=12000, CurrentlyAvailable="Yes", AgentID=3 },
            new Artist{ArtistName="Porter Robinson",ArtistLocation="New York City, NY",ArtistGenre="Electronic, Dubstep, Trip-Hop" ,SignDate=DateTime.Parse("2009-06-01"), BookCost=12000, CurrentlyAvailable="No", AgentID=4 },
            new Artist{ArtistName="Feed Me",ArtistLocation="London, England",ArtistGenre="Electro House, Dubstep, House" ,SignDate=DateTime.Parse("2005-05-07"), BookCost=15000, CurrentlyAvailable="Yes", AgentID=1 },
            new Artist{ArtistName="Medium Troy",ArtistLocation="Eugene, Oregon",ArtistGenre="Electro Funk, Blues" ,SignDate=DateTime.Parse("2001-05-07"), BookCost=10000, CurrentlyAvailable="Yes", AgentID=5 },
            new Artist{ArtistName="U2",ArtistLocation="Dublin, Ireland",ArtistGenre="Rock, Irish Rock" ,SignDate=DateTime.Parse("1999-03-07"), BookCost=200000, CurrentlyAvailable="Yes", AgentID=3 },
            new Artist{ArtistName="Dave Matthews Band",ArtistLocation="Charlottesville, Virginia",ArtistGenre="Rock, Blues, American Rock" ,SignDate=DateTime.Parse("1998-05-28"), BookCost=57000, CurrentlyAvailable="Yes", AgentID=5 },
            new Artist{ArtistName="Griz",ArtistLocation="New York City, New York",ArtistGenre="Hip Hop, Electro Soul, Electronic, Glitch Hop" ,SignDate=DateTime.Parse("1998-07-17"), BookCost=25000, CurrentlyAvailable="Yes", AgentID=2 },
            new Artist{ArtistName="Gramtik",ArtistLocation="New York City, New York",ArtistGenre="Glitch Hop, Dubstep, Hip Hop Soul" ,SignDate=DateTime.Parse("1998-05-28"), BookCost=25000, CurrentlyAvailable="Yes", AgentID=2 },
            };

            artists.ForEach(s => context.Artists.Add(s));
            context.SaveChanges();

            var agents = new List<Agent>
            {
            new Agent{AgentName="Brian Bird",AgentLocation="Eugene, OR", AgentLabel="Sony"},
            new Agent{AgentName="Ron Little",AgentLocation="Eugene, OR", AgentLabel="Epic Records"},
            new Agent{AgentName="Mari Goode", AgentLocation="Eugene,OR", AgentLabel="Virgin Records"},
            new Agent{AgentName="Thomas Edison",AgentLocation="New York City, NY", AgentLabel="LiveWire Entertainment"},
            new Agent{AgentName="Super Mario",AgentLocation="Marioland", AgentLabel="Nintendo"},
            };
            agents.ForEach(s => context.Agents.Add(s));
            context.SaveChanges();

            var bands = new List<Band>
            {
            new Band{BandName="Grizmatik",BandLocation="New York City, NY",BandGenre="Electro, Hip Hop, Funk", BandSignDate=DateTime.Parse("2002-05-26"), BandBookCost=12000, BandAvailable="Yes"},
            new Band{BandName="The Black Keys",BandLocation="Los Angeles, CA",BandGenre="Rock, Alternative", BandSignDate=DateTime.Parse("2001-02-17"), BandBookCost=12000, BandAvailable="Yes"},
            new Band{BandName="Angels and Airwaves",BandLocation="Los Angeles, CA",BandGenre="Pop, Funk", BandSignDate=DateTime.Parse("2006-08-14"), BandBookCost=12000, BandAvailable="Yes"},
            };
            bands.ForEach(s => context.Bands.Add(s));
            context.SaveChanges();

            var shows = new List<Show>
            {
            new Show{ShowName="NewYearsEveBash", ShowCost=55, VenueID=1, TourID=4, ShowDate=DateTime.Parse("2015-12-30")},
            new Show{ShowName="Coachella", ShowCost=350, VenueID=6, TourID=1, ShowDate=DateTime.Parse("2015-4-12")},
            new Show{ShowName="Sasquatch", ShowCost=400, VenueID=2, TourID=4, ShowDate=DateTime.Parse("2015-5-22")},
            new Show{ShowName="Fourth of July Bender", ShowCost=225, VenueID=5, TourID=4, ShowDate=DateTime.Parse("2015-07-04")},
            new Show{ShowName="North of Hell", ShowCost=55, VenueID=1, TourID=4, ShowDate=DateTime.Parse("2015-08-20")},
            new Show{ShowName="Ultra Music Festival", ShowCost=300, VenueID=1, TourID=3, ShowDate=DateTime.Parse("2015-07-30")},
            new Show{ShowName="Bonaroo", ShowCost=400, VenueID=1, TourID=3, ShowDate=DateTime.Parse("2015-06-11")},
            new Show{ShowName="Paradiso", ShowCost=250, VenueID=2, TourID=3, ShowDate=DateTime.Parse("2015-06-11")},
            new Show{ShowName="The Dave Matthews Band at the Gorge", ShowCost=550, VenueID=2, TourID=3, ShowDate=DateTime.Parse("2015-07-22")},
            new Show{ShowName="Stagecoach Festival", ShowCost=650, VenueID=6, TourID=3, ShowDate=DateTime.Parse("2015-07-22")},
            new Show{ShowName="Ultra Music Festival", ShowCost=450, VenueID=7, TourID=3, ShowDate=DateTime.Parse("2015-03-28")},
            
            
            };
            shows.ForEach(s => context.Shows.Add(s));
            context.SaveChanges();

            var tours = new List<Tour>
            {
            new Tour{TourName="Alien Invasion Tour", Continent="North America", TourDescription="The best names in electronic music converge"},
            new Tour{TourName="North of Hell Tour", Continent="North America", TourDescription="The godfathers of Rhymesayers Entertainemtn return with new album: Southsiders."},
            new Tour{TourName="U2 360 Degree Tour", Continent="North America", TourDescription="The highest grossing tour of all time returns to conquer the West Coast."},
            new Tour{TourName="Away From the World Tour", Continent="North America", TourDescription="The Dave Matthews Band continues their widely popular North American tour."},
            new Tour{TourName="Grizmatik: The Massacre Begins", Continent="North America", TourDescription="Legends of the glitchy yet soulful new wave of hip hop, Griz and Gramatik team up in their first Northe American tour."},
            };
            shows.ForEach(s => context.Shows.Add(s));
            context.SaveChanges();


            var venues = new List<Venue>
            {
            new Venue{VenueName="The Guthrie", VenueLocation="Philadelphia, PA", VenueDescription="A newly rennovated 1950's theatre", VenueContact="Ben Thomas", PhoneNumber=7206866286},
            new Venue{VenueName="The Gorge Amipitheatre", VenueLocation="George, WA", VenueDescription="Legendary Canyon Theatre with 3 Stage Areas", VenueContact="Ron Howard", PhoneNumber=606896289},
            new Venue{VenueName="Great Stage Park", VenueLocation="Manchester, TN", VenueDescription="One of the finest venues in the south", VenueContact="Eddie Vedder", PhoneNumber=5417265434},
            new Venue{VenueName="MacDonald Theatre", VenueLocation="George, WA", VenueDescription="Legendary Canyon Theatre with 3 Stage Areas", VenueContact="Ron Howard", PhoneNumber=606896289},
            new Venue{VenueName="The Cuthbert Ampitheatre", VenueLocation="George, WA", VenueDescription="Legendary Canyon Theatre with 3 Stage Areas", VenueContact="Ron Howard", PhoneNumber=606896289},
            new Venue{VenueName="Empire Polo Club", VenueLocation="Indio, CA", VenueDescription="The largest and most epic venue on the West Coast.", VenueContact="Bubba Gump", PhoneNumber=541896289},
            new Venue{VenueName="Bayfront Park", VenueLocation="Miami, FL", VenueDescription="Along the Miami coast line, this legendary location has hosted some of the hottest electronic shows of all time", VenueContact="Ace Venture", PhoneNumber=726896289},
           
            };
            venues.ForEach(s => context.Venues.Add(s));
            context.SaveChanges();

        }
    }
}