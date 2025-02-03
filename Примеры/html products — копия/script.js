// script.js
document.addEventListener("DOMContentLoaded", function () {
    const filterPanel = document.getElementById("filterPanel");
    const toggleButton = document.getElementById("toggleButton");
    let isHidden = false; // Переменная для отслеживания состояния панели

    toggleButton.addEventListener("click", function () {
        isHidden = !isHidden; // Переключаем состояние
        if (isHidden) {
            filterPanel.classList.add("hidden");
            toggleButton.textContent = "Показать фильтры";
        } else {
            filterPanel.classList.remove("hidden");
            toggleButton.textContent = "Скрыть фильтры";
        }
    });
});
