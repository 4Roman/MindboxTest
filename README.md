# MindboxTest

C# библиотека для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

Пример использования функционала по вычислению площади геометрической фигуры:

    IGeometricFigure geometricFigure = Circle.CreateInstance(1.0);
    var area = geometricFigure.CalcSquare();
    
Добавление других фигур:
Для добавления других фигур требуется создать класс (например, Rectangle) и реализовать интерфейс IGeometricFigure.
