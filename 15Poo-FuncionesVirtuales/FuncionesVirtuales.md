# Funciones Virtuales.
como trabajar con funciones virtuales
## Virtual
cuando vamos a tener una cadena de herencia y posiblemente las clases hijas necesiten modificare el metodo en particular. usamos virtual. y cada clase hija podria tener su propia version.
## Override
crea una version propia dentro de la clase hija si esta tiene virtual en la clase padre.
## Sealed
sealed en un metodo que pertenece a una funcion virtual, lo que sucede es que apartir de ese momento hacia abajo en la cadena de herencia nadie podra override al metodo. aunque la super clase tenga el virtual. en este caso la clase producto detenido ya no podra implementar su propia version de calcularprecio, usara la version de su clase padre.