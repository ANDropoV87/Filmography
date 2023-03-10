using Filmography.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Filmography.Models
{
    public class DbNewService
    {
        private FG_DbNewContext _context;
        public static DbNewService Instance { get => DbServiceCreate.instance; }
        private DbNewService()
        {
            _context = new FG_DbNewContext();
        }
        private class DbServiceCreate
        {
            internal static readonly DbNewService instance = new DbNewService();
        }
        public async Task<List<Genre>> GetGenresAsync()
        {
            return await Task.Run(() => _context.Genres.Include("Films").ToList());
        }
        public async Task<List<CountryMovie>> GetCountriesAsync()
        {
            return await Task.Run(() => _context.Countries.Include("Actors").Include("Produsers").Include("FilmProduce").ToList());
        }
        public async Task<List<DemoCountry>> GetDemoCountriesAsync()
        {
            return await Task.Run(() => _context.DemoCountries.Include("Films").ToList());
        }

        public async Task<List<Actor>> GetActorsAsync()
        {
            return await Task.Run(() => _context.Actors.Include("MovieLibrary").Include("Nation").ToList());
        }
        public async Task<List<Produser>> GetProdusersAsync()
        {
            return await Task.Run(() => _context.Produsers.Include("MovieProduce").Include("Nation").ToList());
        }
        public async Task<List<Film>> GetFilmsAsync()
        {
            return await Task.Run(() => _context.Films.Include("Genres").Include("CountryProduce").Include("CountriesDemonstration").Include("FilmProduser").Include("Actors").ToList());
        }
        public async Task<bool> InsertToDbAsync(Actor actor)
        {
            try
            {
                if ((await GetActorsAsync()).Any(w => w.FirstName == actor.FirstName && w.LastName == actor.LastName && w.Birthday.Date == actor.Birthday.Date) == true)
                    return false;
                _context.Actors.Add(actor);
                await Task.Run(() => _context.SaveChanges());
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public async Task<bool> InsertToDbAsync(Produser produser)
        {
            try
            {
                if ((await GetProdusersAsync()).Any(w => w.FirstName == produser.FirstName && w.LastName == produser.LastName && w.Birthday.Date == produser.Birthday.Date) == true)
                    return false;
                _context.Produsers.Add(produser);
                await Task.Run(() => _context.SaveChanges());
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public async Task<bool> InsertToDbAsync(Film film)
        {
            try
            {
                if ((await GetFilmsAsync()).Any(f => f.Name == film.Name && f.Year.Year == film.Year.Year))
                    return false;
                _context.Films.Add(film);
                await Task.Run(() => _context.SaveChanges());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
