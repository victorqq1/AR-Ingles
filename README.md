# AR-Ingles 🦁📱

**Aplicación educativa de Realidad Aumentada para el aprendizaje de vocabulario en inglés en niños.**

AR-Inglés es una aplicación desarrollada como proyecto académico que utiliza **Realidad Aumentada (AR)** para presentar vocabulario en inglés mediante tarjetas físicas. Al reconocer una tarjeta, la aplicación muestra contenido 3D relacionado con el término, combinando elementos visuales e interactivos con mecánicas de gamificación.

El proyecto fue desarrollado utilizando **Unity, C# y Vuforia**.

---

## 📌 Descripción

El aprendizaje de vocabulario en un segundo idioma puede resultar poco atractivo para los niños cuando se basa únicamente en métodos tradicionales. AR-Inglés busca complementar este proceso mediante una experiencia interactiva en la que los estudiantes pueden asociar palabras en inglés con representaciones visuales tridimensionales.

La aplicación utiliza **tarjetas físicas como marcadores**. Cuando una tarjeta es reconocida por la cámara, se muestra el contenido correspondiente en realidad aumentada.

Además del reconocimiento de tarjetas, la aplicación incorpora elementos de gamificación para hacer la interacción más dinámica:

* ⏱️ Cronómetro.
* ⭐ Sistema de puntuación.
* ✅ Retroalimentación para respuestas correctas.
* ❌ Retroalimentación para respuestas incorrectas.
* 🧩 Modelos y recursos 3D.
* 🎮 Interacción mediante una interfaz orientada a niños.

---

## 🕹️ Funcionamiento

El flujo general de la aplicación es:

```text
Tarjeta física
      ↓
Reconocimiento mediante Vuforia
      ↓
Identificación del contenido
      ↓
Visualización del modelo 3D
      ↓
Interacción / respuesta del usuario
      ↓
Retroalimentación
      ↓
Actualización de puntuación y tiempo
```

Las tarjetas permiten trabajar diferentes categorías de vocabulario, incluyendo **animales, objetos y alimentos/vegetales**.

---

## 🛠️ Tecnologías utilizadas

| Tecnología     | Uso                                                                     |
| -------------- | ----------------------------------------------------------------------- |
| **Unity**      | Desarrollo de la aplicación y gestión de escenas, objetos 3D e interfaz |
| **C#**         | Implementación de la lógica y comportamiento de la aplicación           |
| **Vuforia**    | Reconocimiento y seguimiento de las tarjetas utilizadas como marcadores |
| **Modelos 3D** | Representación visual del vocabulario                                   |
| **Git/GitHub** | Control de versiones y almacenamiento del proyecto                      |

---

## 🧩 Principales funcionalidades

### Realidad Aumentada

La aplicación utiliza Vuforia para reconocer tarjetas físicas mediante la cámara y asociarlas con contenido digital.

### Visualización 3D

Después del reconocimiento, la aplicación muestra modelos tridimensionales relacionados con el vocabulario presentado.

### Sistema de puntuación

Las respuestas del usuario se utilizan para actualizar una puntuación durante la actividad.

### Cronómetro

La aplicación incorpora un límite o control de tiempo para añadir un componente dinámico a la actividad.

### Retroalimentación visual

El sistema proporciona indicaciones visuales para diferenciar respuestas correctas e incorrectas.

### Interfaz de usuario

Se desarrollaron diferentes pantallas para la navegación de la aplicación, incluyendo menú, interacción de juego y resultados.

---

## 📚 Contexto académico

El proyecto fue desarrollado como parte del curso:

**Computación Gráfica, Visión Computacional y Multimedia**

El trabajo aborda el uso de tecnologías de Realidad Aumentada como herramienta de apoyo para procesos educativos, específicamente para la enseñanza de vocabulario en inglés.
