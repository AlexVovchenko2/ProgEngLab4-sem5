using System;

namespace lab4
{
    /// <summary>
    /// Представляет футболиста с основными характеристиками и возможностями.
    /// </summary>
    public class Footballer
    {
        private string _name;
        private int _age;
        private string _position;
        private string _club;          
        private int _goalsScored;
        private int _games;

        /// <summary>
        /// Инициализирует нового футболиста с указанными параметрами.
        /// </summary>
        /// <param name="name">Имя футболиста.</param>
        /// <param name="age">Возраст футболиста (должен быть ≥ 16).</param>
        /// <param name="position">Позиция на поле (например, "нападающий", "защитник").</param>
        /// <param name="club">Клуб, за который играет футболист.</param>
        public Footballer(string name, int age, string position, string club = "неизвестен", int games = 0)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            if (age < 16) throw new ArgumentOutOfRangeException(nameof(age), "Возраст должен быть не менее 16.");
            _age = age;
            _position = position ?? "неизвестно";
            _club = club ?? "неизвестен";
            _goalsScored = 0;
            _games = games;
        }

        /// <summary>
        /// Возвращает информацию о футболисте в виде строки.
        /// </summary>
        /// <returns>Строковое представление объекта Footballer.</returns>
        public override string ToString()
        {
            return $"{_name}, {_age} лет, позиция: {_position}, клуб: {_club}, " +
           $"голов: {_goalsScored}, игр: {_games}";
        }

        /// <summary>
        /// Добавляет голы к общему счёту футболиста.
        /// </summary>
        /// <param name="count">Количество голов для добавления (должно быть ≥ 0).</param>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается, если count меньше 0.</exception>
        public void ScoreGoals(int count)
        {
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Количество голов не может быть отрицательным.");
            _goalsScored += count;
        }

        /// <summary>
        /// Изменяет клуб футболиста.
        /// </summary>
        /// <param name="newClub">Название нового клуба.</param>
        public void ChangeClub(string newClub)
        {
            _club = newClub ?? throw new ArgumentNullException(nameof(newClub));
        }

        /// <summary>
        /// Проверяет, является ли футболист опытным (возраст ≥ 28 и забил хотя бы 50 голов).
        /// </summary>
        /// <returns><c>true</c>, если опытный; иначе <c>false</c>.</returns>
        public bool IsExperienced() => _age >= 28 && _goalsScored >= 50;

        /// <summary>
        /// Статический метод для сравнения двух футболистов по количеству голов.
        /// </summary>
        /// <param name="a">Первый футболист.</param>
        /// <param name="b">Второй футболист.</param>
        /// <returns>Положительное число, если у <paramref name="a"/> больше голов;
        /// отрицательное — если у <paramref name="b"/>;
        /// 0 — если одинаково.</returns>
        public static int CompareByGoals(Footballer a, Footballer b)
        {
            if (a == null) return b == null ? 0 : -1;
            if (b == null) return 1;
            return a._goalsScored.CompareTo(b._goalsScored);
        }


        /// <summary>
        /// Увеличивает счётчик сыгранных игр.
        /// </summary>
        /// <param name="count">Количество добавляемых игр (≥ 0).</param>
        public void AddGames(int count)
        {
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
            _games += count;
        }

    }
}