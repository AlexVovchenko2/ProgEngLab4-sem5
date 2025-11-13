using System;

namespace lab4
{
    /// <summary>
    /// Представляет баскетболиста с основными атрибутами: очки, подборы, блок-шоты.
    /// </summary>
    public class Basketballer
    {
        private string _name;
        private int _heightCm;      
        private int _points;
        private int _rebounds;      
        private int _blocks;
        private int _games;

        /// <summary>
        /// Создаёт нового баскетболиста.
        /// </summary>
        /// <param name="name">Имя баскетболиста.</param>
        /// <param name="heightCm">Рост в сантиметрах (150–250).</param>
        public Basketballer(string name, int heightCm, int games = 0)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            if (heightCm < 150 || heightCm > 250)
                throw new ArgumentOutOfRangeException(nameof(heightCm), "Рост должен быть от 150 до 250 см.");
            _heightCm = heightCm;
            _points = 0;
            _rebounds = 0;
            _blocks = 0;
            _games = games;
        }

        /// <summary>
        /// Добавляет набранные очки.
        /// </summary>
        /// <param name="points">Количество очков (≥ 0).</param>
        public void AddPoints(int points)
        {
            if (points < 0) throw new ArgumentOutOfRangeException(nameof(points));
            _points += points;
        }

        /// <summary>
        /// Добавляет подборы.
        /// </summary>
        /// <param name="rebounds">Количество подборов (≥ 0).</param>
        public void AddRebounds(int rebounds)
        {
            if (rebounds < 0) throw new ArgumentOutOfRangeException(nameof(rebounds));
            _rebounds += rebounds;
        }

        /// <summary>
        /// Добавляет блок-шоты.
        /// </summary>
        /// <param name="blocks">Количество блок-шотов (≥ 0).</param>
        public void AddBlocks(int blocks)
        {
            if (blocks < 0) throw new ArgumentOutOfRangeException(nameof(blocks));
            _blocks += blocks;
        }

        /// <summary>
        /// Оценивает продуктивность игрока по формуле: очки + подборы + блок-шоты.
        /// </summary>
        /// <returns>Целочисленная оценка продуктивности.</returns>
        public int GetProductivityScore()
        {
            return _points + _rebounds + _blocks;
        }

        /// <summary>
        /// Возвращает описание игрока, включая рост и статистику.
        /// </summary>
        /// <returns>Строковое представление объекта.</returns>
        public override string ToString()
        {
            return $"{_name} ({_heightCm} см), " +
           $"очки: {_points}, подборы: {_rebounds}, блоки: {_blocks}, игры: {_games}";
        }

        /// <summary>
        /// Является ли игрок "центровым": рост ≥ 205 см.
        /// </summary>
        /// <returns><c>true</c>, если рост ≥ 205 см; иначе <c>false</c>.</returns>
        public bool IsCenter() => _heightCm >= 205;



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