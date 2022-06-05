# Test-Task

 Тестовый проект для Axelbolt

## Немного о проекте

Идея проекта: Таракн(ы) появляются на краю экрана и бегут к финишу. Курсор игрока является пугающей таракана/-ов зоной (подробнее о ней ниже), от которой они должны бежать. Про радиус курсора - представьте, что можно менять размер курсора мыши, от которого убегает таракан. При достижении финиша тараканом - финальный экран и предложение начать игру заново. От себя добавил ещё простенький набор счета. 


* Scare Component - Сделал на него основной упор с визуальной точки зрения.ю У компонента есть визуальное отображение 2 зон - Желтой, которая не полностью пугает таракана, но имеет влияние на него по мере приближения к красной зоне; Красной, которая полностью пугает таракана и он бежит от нее в максимально эффективном направлении.
* Полностью тестируемые компоненты, и как следствие системы, так как за все в отдельности (движение, направление к цели, цель, пугание и пугательность(?)) отвечают отдельные, взаимо заменяемые компоненты.
* Простенький GameManager для такого проекта который делит его на условные стейты (Start-Game-Final Screen).
* Простенький "Завод" который спаунит таракнчиков по вызову)
