// script.js
const container = document.getElementById("container");

class fallingCube {
  constructor(fallSpeed, x, y) {
    this.fallSpeed = fallSpeed;
    this.x = x;
    this.y = y;
  }

  animate(cube_div) {
    const rect = cube_div.getBoundingClientRect();

    // Обновляем позицию кубика
    cube_div.style.top = `${rect.top + this.fallSpeed}px`;

    // Проверяем, достиг ли кубик дна экрана
    if (rect.top < window.innerHeight) {
      requestAnimationFrame(() => this.animate(cube_div)); // Продолжаем анимацию
    } else {
      cube_div.remove(); // Удаляем кубик, если он вышел за пределы экрана
    }
  }

  create_div() {
    const cube_div = document.createElement("div");
    cube_div.className = "cube";

    cube_div.style.left = `${this.x}px`;
    cube_div.style.top = `${this.y}px`;
    container.appendChild(cube_div);

    return cube_div;
  }

  run() {
    const cube_div = this.create_div();

    requestAnimationFrame(() => this.animate(cube_div)); // Запускаем анимацию
  }
}

// Создаем кубы каждые 500 мс
setInterval(() => {
  const randomX = Math.random() * (window.innerWidth - 50); // 50 - ширина кубика
  const cube = new fallingCube(2, randomX, -50);

  cube.run();
}, 500);
