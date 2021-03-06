<Query Kind="Statements" />

//***************************************************************
//Что такое OCP?
//Фиксация интерфейса класса/модуля и возможность 
//изменения реализации/поведения с целью - борьба 
//со сложностью и ограничение изменений минимальным числом модулей.
//(когда это будет нужно)
//Смысл: ограничить распространение изменений минимальным числом 
//классов/модулей; позволить вести параллельную разработку путем
//фиксации интерфейсов классов и открытости реализаций.
//***************************************************************
//Как реализуем OCP?
//С помощью инкапсуляции, которая дает возможность изменять реализацию
//без изменения интерфейса, и посредством наследования, что позволяет
//заменить реализацию, не затрагивая существующих клиентов 
//базового класса.
//***************************************************************
//Классический объектный подход позволяет легко добавлять новые типы
//в существующую иерархию типов, а функциональный подход позволяет 
//легко добавлять новые операции. Проблема однобокости каждого из 
//решений является одной из классических проблем программирования и
//носит название Expression Problem
//***************************************************************
//========================================================
//Типичными примерами нарушения принципа «открыт / закрыт»
//являются следующие.
//=========================================================
// - Интерфейс класса является нестабильным. Постоянные изменения 
//интерфейса класса, используемого во множестве мест, приводят
//к постоянным измене- ниям во многих частях системы.
// - «Размазывание» информации об иерархии типов. В коде постоянно
//используются понижающие приведения типов (downcasting), 
//что «размазывает» информацию об иерархии типов по коду
//приложения.Это затрудняет добавление новых типов и усложняет 
//понимание текущего решения.










