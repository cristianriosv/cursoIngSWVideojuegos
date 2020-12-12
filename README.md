# Curso Ing. de SW. & Videojuegos 
## 2da chance


# Diagrama de modelado de clases

![Diagrama Modelado de clases](./ModeladoClases.jpg?raw=true "Diagrama Modelado de clases") 

## Respuesta de preguntas:

1 - En C#, ¿para qué sirve una propiedad?.  
Una propiedad se define dentro de un objeto clase para poder acceder a sus atributos privados u ocultos, tanto para modificarlos como para leerlos. Es como una especie de combinación de una variable y un método que se ocupa de obtener datos (get) como modificar su valor (set).
Si se evita exponer el método "get" entonces la variable pasa a ser sólo de escritura y si se evita exponer "set" entonces la variable es de sólo lectura.  
Todo esto facilita el acceso y la manipulación del código en los atributos definidos.

2 - ¿Cuándo utilizaría acceso protegido en los miembros de una clase?  
El acceso protegido lo utilizaría para trabajar con miembros privados, es decir, que solamente puedan ser accedidos/modificados desde la clase donde son declarados, sumado a todas las clases derivadas de dicha clase padre. La diferencia entre protegido y privado reside en que dicho miembro puede ser accedido además por todas sus clases derivadas hijas y ser tratadas como privadas propias.

3 - En UML, ¿qué tipo de relación es la siguiente?  
La línea discontinua con punta de flecha vacía se refiera a la implementación de interfaces. La relación refiere a que se debe cumplir cierto contrato de métodos y atributos especificados. También se puede definir como un molde o plantilla de implementación, sin ocuparse de la lógica.

4 - Explique con sus palabras qué implica una relación de Dependencia entre dos clases.  
La relación de dependencia refiera a que la clase dependiente reacciona con algún cambio de la clase independiente. Es decir que una afecta a la otra tanto si se modifica o si se elimina, las clases dependientes van a reaccionar a esos cambios ya que dependen del estado de la clase independiente.

5 - Indique V o F según corresponda. Si es F, fundamente su respuesta:  
* a - Un constructor es un método que se invoca de forma automática cuando se instancia el objeto de la clase. **V**  
* b- Un constructor debe tener siempre el mismo nombre de la clase.  **F**   
**Depende del lenguaje/framework, en c# sí debe ser del mismo nombre.**
* c- Un constructor puede retornar un valor. **F**  
**Un constructor no devuelve ningún valor ya que se utiliza para inicializar la instancia del objeto**  
* d - Un constructor puede ser privado. **V**  
* e - Una clase sólo puede tener declarado un único constructor. **F**  
**Se pueden declarar varios constructores que requieran distintos parámetros o distintas firmas según se necesite iniciar diferentes estados de la instancia**
