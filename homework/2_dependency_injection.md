Начнем с разработки макета. Наш интернет магазин будем предоставлять список товаров. Стоимость товаров будет изменяться в зависимости от дня недели.
База данных – деталь реализации, поэтому мы пока не будем о ней думать.
1. Создайте модель товара, добавьте каталог со списком товаров. Заполните список товаров любыми товарами (от 3-х и более).
2. По адресу /catalog покажите список товаров. Помните про DIP.
3. В субботу и воскресенье стоимость товара должна увеличиваться на 50%.
4. Создайте абстракцию, назначение которой - предоставлять текущее время. \
4.1. Сделайте реализацию, предоставляющую текущее время во временной зоне UTC. \
4.2. Внедрите получившуюся абстракцию и реализацию в виде зависимости в свой проект. Оптимальный lifetime зависимости выберите самостоятельно. \
4.3 Добавьте эту зависимость в свой сервис и разрешите ее. \
4.4 * Напишите тест, проверяющий логику вашего сервиса.
5. Загрузите решение на GitHub
