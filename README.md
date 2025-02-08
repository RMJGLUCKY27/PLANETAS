# PLANETAS

Este proyecto en C# ⚙️ simula la rotación solar y la traslación de los planetas básico en Unity . Se adjunta al GameObject que representa el Sol ☀️ y controla la rotación del Sol sobre su propio eje, así como la órbita de la Tierra  y la Luna  alrededor del Sol y la Tierra, respectivamente.

**Variables:**

*   `tagTierra (string)`: Almacena el tag del GameObject que representa la Tierra . Los tags son etiquetas ️ que permiten identificar GameObjects en la escena.
*   `tagLuna (string)`: Almacena el tag del GameObject que representa la Luna .
*   `velocidadOrbitalTierra (float)`: Define la velocidad de la órbita de la Tierra  alrededor del Sol ☀️.
*   `velocidadOrbitalLuna (float)`: Define la velocidad de la órbita de la Luna  alrededor de la Tierra .
*   `velocidadRotacionSol (float)`: Define la velocidad de rotación del Sol ☀️ sobre su propio eje.
*   `tierra (Transform)`: Variable de tipo Transform ⚙️ que almacenará la referencia al componente Transform del GameObject Tierra . El componente Transform contiene información sobre la posición, rotación y escala de un GameObject.
*   `luna (Transform)`: Variable de tipo Transform ⚙️ que almacenará la referencia al componente Transform del GameObject Luna .
*   `sol (Transform)`: Variable de tipo Transform ⚙️ que almacenará la referencia al componente Transform del GameObject Sol ☀️ (que es el objeto al que está adjunto este script).

**Método `Start()`:**

Este método se ejecuta una vez al inicio del juego . Su función principal es encontrar los GameObjects que representan la Tierra  y la Luna  utilizando sus tags y obtener sus componentes Transform.

1.  `GameObject.FindGameObjectWithTag(tagTierra)`: Busca un GameObject en la escena que tenga el tag especificado en la variable `tagTierra`.
2.  `GameObject.FindGameObjectWithTag(tagLuna)`: Busca un GameObject en la escena que tenga el tag especificado en la variable `tagLuna`.
3.  Se realizan comprobaciones ✅ para asegurar que se encontraron los GameObjects con los tags especificados. Si no se encuentran, se muestra un mensaje de error ❌ en la consola y se sale del método.
4.  Se obtienen los componentes Transform de los GameObjects encontrados y se almacenan en las variables `tierra` y `luna`.
5.  Se asigna el componente Transform del objeto actual (el Sol ☀️) a la variable `sol` utilizando `transform`.

**Método `Update()`:**

Este método se ejecuta en cada frame del juego . Su función principal es controlar la rotación del Sol ☀️ y las órbitas de la Tierra  y la Luna .

1.  Se realizan comprobaciones ✅ para asegurar que las variables `tierra`, `luna` y `sol` no sean nulas (es decir, que se encontraron los GameObjects y se obtuvieron sus componentes Transform).
2.  `sol.Rotate(Vector3.forward * velocidadRotacionSol * Time.deltaTime)`: Rota el Sol ☀️ sobre su propio eje. `Vector3.forward` indica que la rotación se realiza alrededor del eje Z. `Time.deltaTime` se utiliza para que la rotación sea suave y consistente, independientemente de la velocidad de fotogramas del juego.
3.  `tierra.RotateAround(sol.position, Vector3.forward, velocidadOrbitalTierra * Time.deltaTime)`: Hace que la Tierra  orbite alrededor del Sol ☀️. `sol.position` indica el centro de la órbita (la posición del Sol ☀️).
4.  `luna.RotateAround(tierra.position, Vector3.forward, velocidadOrbitalLuna * Time.deltaTime)`: Hace que la Luna  orbite alrededor de la Tierra . `tierra.position` indica el centro de la órbita (la posición de la Tierra ).

**En resumen:**

Este script utiliza tags ️ para identificar los GameObjects que representan la Tierra  y la Luna , y luego utiliza sus componentes Transform ⚙️ para controlar sus movimientos. El método `Start()` se encarga de inicializar las variables y encontrar los objetos, mientras que el método `Update()` se encarga de actualizar sus movimientos en cada frame del juego .
