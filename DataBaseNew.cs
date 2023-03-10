using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Filmography.Models;

namespace Filmography
{
    public class DataBaseNew
    {
        DbNewService service;

        public DataBaseNew()
        {
            service = DbNewService.Instance;
        }
        public async Task<bool> AddFilmsAndActorsAsync()
        {
            try
            {
                if (await AddActors() == false)
                    return false;
                if (await AddFilms() == false)
                    return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task<CountryMovie> GetCountry(string countryName)
        {
            return (await service.GetCountriesAsync()).FirstOrDefault(c => c.Name == countryName) ?? new CountryMovie() { Name = countryName };
        }
        private async Task<DemoCountry> GetDemoCountry(string countryName)
        {
            return (await service.GetDemoCountriesAsync()).FirstOrDefault(c => c.Name == countryName) ?? new DemoCountry() { Name = countryName };
        }
        private async Task<Genre> GetGenre(string genreName)
        {
            return (await service.GetGenresAsync()).FirstOrDefault(c => c.Name == genreName) ?? new Genre() { Name = genreName };
        }
        private async Task<Actor> GetActor(string firstName, string lastName)
        {
            return (await service.GetActorsAsync()).FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
        }
        private async Task<Produser> GetProduser(string firstName, string lastName)
        {
            return (await service.GetProdusersAsync()).FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);
        }
        private async Task<bool> ActorToProducer(Actor actor)
        {
            Produser produser = new Produser()
            {
                FirstName = actor.FirstName,
                LastName = actor.LastName,
                Sex = actor.Sex,
                Birthday = actor.Birthday,
                Nation = actor.Nation,
                City = actor.City,
                FinState = actor.FinState
            };
            try
            {
                await service.InsertToDbAsync(produser);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task<bool> AddActors()
        {
            try
            {
                Actor a1 = new Actor() //
                {
                    FirstName = "Том",
                    LastName = "Хэнкс",
                    Sex = "мужской",
                    Birthday = new DateTime(1950, 5, 5),
                    Nation = await GetCountry("США"),
                    City = "Нью-Джерси",
                    FinState = 680000000
                };
                await service.InsertToDbAsync(a1);
                await ActorToProducer(a1);

                Actor a2 = new Actor()
                {
                    FirstName = "Колин",
                    LastName = "Фаррелл",
                    Sex = "мужской",
                    Birthday = new DateTime(1976, 5, 31),
                    Nation = await GetCountry("Ирландия"),
                    City = "Дублин",
                    FinState = 169000000
                };
                await service.InsertToDbAsync(a2);
                await ActorToProducer(a2);


                Actor a3 = new Actor()
                {
                    FirstName = "Мэттью",
                    LastName = "МакКонахи",
                    Sex = "мужской",
                    Birthday = new DateTime(1969, 11, 4),
                    Nation = await GetCountry("США"),
                    City = "Увалд, Техас",
                    FinState = 625000000
                };
                await service.InsertToDbAsync(a3);
                await ActorToProducer(a3);

                Actor a4 = new Actor()
                {
                    FirstName = "Махершала",
                    LastName = "Али",
                    Sex = "мужской",
                    Birthday = new DateTime(1974, 2, 16),
                    Nation = await GetCountry("США"),
                    City = "Оклэнд,Калифорния",
                    FinState = 95000000
                };
                await service.InsertToDbAsync(a4);
                await ActorToProducer(a4);

                Actor a5 = new Actor
                {
                    FirstName = "Сильвестер",
                    LastName = "Сталоне",
                    Sex = "мужской",
                    Birthday = new DateTime(1946, 7, 6),
                    Nation = await GetCountry("США"),
                    City = "Нью - Йорк",
                    FinState = 400000000
                };
                await service.InsertToDbAsync(a5);
                await ActorToProducer(a5);


                Actor a6 = new Actor()
                {
                    FirstName = "Джим",
                    LastName = "Кэрри",
                    Sex = "мужской",
                    Birthday = new DateTime(1962, 1, 17),
                    Nation = await GetCountry("Канада"),
                    City = "Ньюмаркет",
                    FinState = 70000000
                };
                await service.InsertToDbAsync(a6);
                await ActorToProducer(a6);


                Actor a7 = new Actor()
                {
                    FirstName = "Питер",
                    LastName = "Грин",
                    Sex = "мужской",
                    Birthday = new DateTime(1965, 10, 8),
                    Nation = await GetCountry("США"),
                    City = "Нью - Джерси",
                    FinState = 88000000
                };
                await service.InsertToDbAsync(a7);
                await ActorToProducer(a7);
            

                Actor a8 = new Actor()
                {
                    FirstName = "Никита",
                    LastName = "Михалков",
                    Sex = "мужской",
                    Birthday = new DateTime(1945, 10, 21),
                    Nation = await GetCountry("СССР"),
                    City = "Москва",
                    FinState = 55000000
                };
                await service.InsertToDbAsync(a8);
                await ActorToProducer(a8);


                Actor a9 = new Actor()
                {
                    FirstName = "Вуди",
                    LastName = "Харрельсон",
                    Sex = "мужской",
                    Birthday = new DateTime(1961, 7, 23),
                    Nation = await GetCountry("США"),
                    City = "Техас",
                    FinState = 45000000
                };
                await service.InsertToDbAsync(a9);
                await ActorToProducer(a9);

                Actor a10 = new Actor()
                {
                    FirstName = "Уилл",
                    LastName = "Смит",
                    Sex = "мужской",
                    Birthday = new DateTime(1968, 9, 25),
                    Nation = await GetCountry("США"),
                    City = "Филадельфия",
                    FinState = 234000000
                };
                await service.InsertToDbAsync(a10);
                await ActorToProducer(a10);

                Actor a11 = new Actor()
                {
                    FirstName = "Томми Ли",
                    LastName = "Джонс",
                    Sex = "мужской",
                    Birthday = new DateTime(1946, 9, 15),
                    Nation = await GetCountry("США"),
                    City = "Техас",
                    FinState = 157000000
                };
                await service.InsertToDbAsync(a11);
                await ActorToProducer(a11);


                Produser p1 = new Produser() //4 продюсера
                {
                    FirstName = "Винс",
                    LastName = "Гиллиган",
                    Sex = "мужской",
                    Birthday = new DateTime(1967, 2, 10),
                    Nation = await GetCountry("США"),
                    City = "КВиржиния",
                    FinState = 75000000
                };
                await service.InsertToDbAsync(p1);

                Produser p2 = new Produser()
                {
                    FirstName = "Джеймс",
                    LastName = "Кэмерон",
                    Sex = "мужской",
                    Birthday = new DateTime(1954, 8, 16),
                    Nation = await GetCountry("Канада"),
                    City = "Капускасинг",
                    FinState = 900000000
                };
                await service.InsertToDbAsync(p2);

                Produser p3 = new Produser()
                {
                    FirstName = "Ума",
                    LastName = "Турман",
                    Sex = "Женский",
                    Birthday = new DateTime(1970, 4, 29),
                    Nation = await GetCountry("США"),
                    City = "Бостон",
                    FinState = 350000000
                };

                await service.InsertToDbAsync(p3);

                Produser p4 = new Produser()
                {
                    FirstName = "Квентин",
                    LastName = "Тарантино",
                    Sex = "мужской",
                    Birthday = new DateTime(1963, 3, 27),
                    Nation = await GetCountry("США"),
                    City = "Ноксвил",
                    FinState = 121000000
                };
                await service.InsertToDbAsync(p4);

                

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private async Task<bool> AddFilms() // Фильмы база 4 шт
        {
            try
            {
                Film film1 = new Film()
                {
                    Name = "Аватор",
                    Year = new DateTime(2009, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 8.1f,
                    Budget = 237000000,
                    BoxOffice = 2923905528,
                    Viewers = 3000000000,
                    FilmProduser = await GetProduser("Джеймс Кэмерон", "Джон Ландау")
                };
                film1.Genres.Add(await GetGenre("Боевик"));
                film1.Genres.Add(await GetGenre("Фантастика"));

                film1.Actors.Add(await GetActor("Сэм", "Уортингтон"));
                film1.Actors.Add(await GetActor("Зои", "Салдана"));

                film1.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Бразилия")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film1.CountriesDemonstration.Add((await GetDemoCountry("Индия")));

                await service.InsertToDbAsync(film1);

                Film film2 = new Film()
                {
                    Name = "Форест Гамп",
                    Year = new DateTime(1994, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 8.9f,
                    Budget = 55000000,
                    BoxOffice = 329694499,
                    Viewers = 2000000000,
                    FilmProduser = await GetProduser("Венди Файнерман", "Чарльз Невирт"),
                };
                film2.Genres.Add(await GetGenre("Приключение"));
                film2.Genres.Add(await GetGenre("Фэнтези"));

                film2.Actors.Add(await GetActor("Том", "Хэнкс"));
                film2.Actors.Add(await GetActor("Робин", "Райт"));

                film2.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film2.CountriesDemonstration.Add((await GetDemoCountry("Сингапур")));

                await service.InsertToDbAsync(film2);

                Film film3 = new Film()
                {
                    Name = "Миссия невыполнима Fallout",
                    Year = new DateTime(2018, 1, 1),
                    CountryProduce = await GetCountry("США"),
                    Rating = 7.3f,
                    Budget = 17800000,
                    BoxOffice = 792696359,
                    Viewers = 2600000000,
                    FilmProduser = await GetProduser("Том", "Круз"),
                };
                film3.Genres.Add(await GetGenre("Боевик"));
                film3.Genres.Add(await GetGenre("Детектив"));

                film3.Actors.Add(await GetActor("Том", "Круз"));

                film3.CountriesDemonstration.Add((await GetDemoCountry("Аргентина")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Бразилия")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("США")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Канада")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Южная корея")));
                film3.CountriesDemonstration.Add((await GetDemoCountry("Сингапур")));

                await service.InsertToDbAsync(film3);

                Film film4 = new Film()
                {
                    Name = "Сибирский цирюльник",
                    Year = new DateTime(1998, 1, 1),
                    CountryProduce = await GetCountry("Россия"),
                    Rating = 7.8f,
                    Budget = 35000000,
                    BoxOffice = 3051279,
                    Viewers = 180000000,
                    FilmProduser = await GetProduser("Никита", "Михалков")
                };
                film4.Genres.Add(await GetGenre("Драма"));
                film4.Genres.Add(await GetGenre("Мелодрама"));
                film4.Genres.Add(await GetGenre("История"));

                film4.Actors.Add(await GetActor("Никита", "Михалков"));

                film4.CountriesDemonstration.Add((await GetDemoCountry("Россия")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Германия")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Франция")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Китай")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Япония")));
                film4.CountriesDemonstration.Add((await GetDemoCountry("Индия")));

                await service.InsertToDbAsync(film4);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
