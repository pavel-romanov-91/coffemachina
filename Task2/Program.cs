﻿
using System;

namespace coffeemachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeemachine = new CoffeeMachine();
            // CoffeeMachine.PrintState();
            coffeemachine.Start();
        }
    }
}



// Включение / выключение кофемашины
// Добавить воды
// Защита от перелива
// Добавить кофе
// Добавить молоко
// Проверить, сколько молока
// Проверить, сколько воды
// Проверить, есть ли кофе
// Проверить, не нужно ли ее очистить
// Очистка кофе машины
// Приготовить Эспрессо
// Приготовить Капучино
// Добавить функционал создания 3 порций любого напитка
// Добавить функционал выбора количества кружек напитка для изготовления
// Добавить функционал логирования работы кофемашины с возможностью вывода всех приготовленных напитков
// Добавить возможность добавления профилей с фиксированными напитками и последующим быстрым набором
// Добавить функционал вывода рецепта напитка по названию напитка

// Защита от перелива воды
// Лимит на зерна в машине
// Защита от перелива молока
// Предотвратить ненужную чистку
// При приготовлении кофе должны быть соблюдены:
// Проверка, на наличие всех ингредиентов
// Проверка на очистку
// Кофемашина должна быть включена
// Добавление и получение данных через getters, setters
// Реализовать статичные методы
// Реализовать статичные поля
// Использовать enum
// Залогированы должны быть только те операции, которые были выполнены
// Все исключения обрабатывать путем пробрасывание ошибки и обработки через конструкцию try / catch