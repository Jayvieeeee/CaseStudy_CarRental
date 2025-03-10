const menuOpenButton = document.querySelector("#menu-open-button");
const menuCloseButton = document.querySelector("#menu-close-button");
const sections = document.querySelectorAll("section");
const navLinks = document.querySelectorAll(".nav-link");

// Open mobile menu
menuOpenButton.addEventListener("click", () => {
    document.body.classList.toggle("show-mobile-menu");
});

// Close mobile menu
menuCloseButton.addEventListener("click", () => menuOpenButton.click());

// Highlight active nav link on scroll
window.addEventListener("scroll", () => {
    let current = "";

    sections.forEach((section) => {
        const sectionTop = section.offsetTop;
        const sectionHeight = section.clientHeight;
        if (window.scrollY >= sectionTop - sectionHeight / 3) {
            current = section.getAttribute("id");
        }
    });

    navLinks.forEach((link) => {
        link.classList.remove("active");
        if (link.getAttribute("href").includes(current)) {
            link.classList.add("active");
        }
    });
});

// Swiper setup
document.addEventListener("DOMContentLoaded", function () {
    var swiper = new Swiper(".mySwiper", {
        slidesPerView: 4, // Start with 3 images
        spaceBetween: 10, // Consistent spacing
        loop: true,
        navigation: {
            nextEl: ".swiper-button-next",
            prevEl: ".swiper-button-prev",
        },
        breakpoints: {
            1024: { slidesPerView: 4 }, // Desktop
            768: { slidesPerView: 2 },  // Tablets
            480: { slidesPerView: 1 },  // Mobile
        }
    });

    // Equalize car card heights
    function adjustCarHeight() {
        let maxHeight = 0;
        const cars = document.querySelectorAll(".car");

        cars.forEach(car => {
            car.style.height = "auto"; // Reset height to recalculate
        });

        cars.forEach(car => {
            maxHeight = Math.max(maxHeight, car.offsetHeight);
        });

        cars.forEach(car => {
            car.style.height = maxHeight + "px";
        });
    }

    // Ensure images are loaded before adjusting height
    const carImages = document.querySelectorAll(".car img");
    let imagesLoaded = 0;

    carImages.forEach(img => {
        img.addEventListener("load", () => {
            imagesLoaded++;
            if (imagesLoaded === carImages.length) {
                adjustCarHeight();
            }
        });

        // In case images are already cached
        if (img.complete) {
            imagesLoaded++;
        }
    });

    // Re-adjust on window resize
    window.addEventListener("resize", adjustCarHeight);
});
