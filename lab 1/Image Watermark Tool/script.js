const canvas = document.getElementById("canvas");
const ctx = canvas.getContext("2d");

let image = null;

// Controls
const imageInput = document.getElementById("imageInput");
const watermarkText = document.getElementById("watermarkText");
const fontFamily = document.getElementById("fontFamily");
const fontSize = document.getElementById("fontSize");
const fontColor = document.getElementById("fontColor");
const opacity = document.getElementById("opacity");
const rotation = document.getElementById("rotation");
const shadow = document.getElementById("shadow");
const position = document.getElementById("position");

const fontSizeVal = document.getElementById("fontSizeVal");
const opacityVal = document.getElementById("opacityVal");
const rotationVal = document.getElementById("rotationVal");

const dropArea = document.getElementById("dropArea");

// Upload Image
function loadImage(file) {

    if (!file) return;

    const reader = new FileReader();

    reader.onload = function (e) {

        image = new Image();

        image.onload = function () {

            canvas.width = image.width;
            canvas.height = image.height;

            canvas.style.display = "block";

            drawCanvas();
        };

        image.src = e.target.result;
    };

    reader.readAsDataURL(file);
}

// Draw Canvas
function drawCanvas() {

    if (!image) return;

    ctx.clearRect(0, 0, canvas.width, canvas.height);

    // Draw image
    ctx.drawImage(image, 0, 0);

    const text = watermarkText.value;

    ctx.save();

    let x = canvas.width / 2;
    let y = canvas.height / 2;

    switch (position.value) {

        case "top-left":
            x = 80;
            y = 80;
            break;

        case "top-right":
            x = canvas.width - 80;
            y = 80;
            break;

        case "bottom-left":
            x = 80;
            y = canvas.height - 80;
            break;

        case "bottom-right":
            x = canvas.width - 80;
            y = canvas.height - 80;
            break;

        default:
            x = canvas.width / 2;
            y = canvas.height / 2;
    }

    ctx.translate(x, y);

    ctx.rotate(rotation.value * Math.PI / 180);

    ctx.globalAlpha = opacity.value;

    ctx.font = `${fontSize.value}px ${fontFamily.value}`;

    ctx.fillStyle = fontColor.value;

    ctx.shadowBlur = shadow.value;
    ctx.shadowColor = "black";

    ctx.textAlign = "center";
    ctx.textBaseline = "middle";

    ctx.fillText(text, 0, 0);

    ctx.restore();
}

// File Upload
imageInput.addEventListener("change", (e) => {
    loadImage(e.target.files[0]);
});

// Drag & Drop
dropArea.addEventListener("dragover", (e) => {
    e.preventDefault();
});

dropArea.addEventListener("drop", (e) => {

    e.preventDefault();

    const file = e.dataTransfer.files[0];

    loadImage(file);
});

// Click Upload Area
dropArea.addEventListener("click", () => {
    imageInput.click();
});

// Live Updates
[
    watermarkText,
    fontFamily,
    fontSize,
    fontColor,
    opacity,
    rotation,
    shadow,
    position
].forEach(control => {

    control.addEventListener("input", () => {

        fontSizeVal.textContent =
            fontSize.value + "px";

        opacityVal.textContent =
            Number(opacity.value).toFixed(2);

        rotationVal.textContent =
            rotation.value + "°";

        drawCanvas();
    });

});

// Download PNG
document
.getElementById("downloadPNG")
.addEventListener("click", () => {

    if (!image) {
        alert("Upload image first");
        return;
    }

    const link = document.createElement("a");

    link.download = "watermark.png";

    link.href =
        canvas.toDataURL("image/png");

    link.click();
});

// Download JPG
document
.getElementById("downloadJPG")
.addEventListener("click", () => {

    if (!image) {
        alert("Upload image first");
        return;
    }

    const link = document.createElement("a");

    link.download = "watermark.jpg";

    link.href =
        canvas.toDataURL(
            "image/jpeg",
            1
        );

    link.click();
});

// Theme Toggle
const themeBtn =
    document.getElementById("themeBtn");

let darkMode = true;

themeBtn.addEventListener("click", () => {

    if (darkMode) {

        document.body.style.background =
            "linear-gradient(135deg,#f8fafc,#e2e8f0,#cbd5e1)";

        document.body.style.color = "#000";

        themeBtn.innerHTML =
            "☀️ Light Mode";

        darkMode = false;

    } else {

        document.body.style.background =
            "linear-gradient(135deg,#0f172a,#111827,#1e293b)";

        document.body.style.color = "#fff";

        themeBtn.innerHTML =
            "🌙 Dark Mode";

        darkMode = true;
    }

});

// Get Started Button
const getStartedBtn =
    document.querySelector(".hero-btn");

if (getStartedBtn) {

    getStartedBtn.addEventListener(
        "click",
        () => {

            document
            .querySelector(".workspace")
            .scrollIntoView({
                behavior: "smooth"
            });

            setTimeout(() => {

                imageInput.click();

            }, 700);

        }
    );
}