const menuOpenButton = document.querySelector("#menu-open-button");
const menuCloseButton = document.querySelector("#menu-close-button");
const sections = document.querySelectorAll('section');
const navLinks = document.querySelectorAll('.nav-link');


menuOpenButton.addEventListener("click", () => {
    document.body.classList.toggle("show-mobile-menu");
});

menuCloseButton.addEventListener("click", () => menuOpenButton.click());

window.addEventListener('scroll', () => {
    let current = '';

    sections.forEach(section => {
        const sectionTop = section.offsetTop;
        const sectionHeight = section.clientHeight;
        if (window.scrollY >= sectionTop - sectionHeight / 3) {
            current = section.getAttribute('id');
        }
    })

    navLinks.forEach(link => {
        link.classList.remove('active');
        if (link.getAttribute('href').includes(current)) {
            link.classList.add('active');
        }
    });

});
document.addEventListener("DOMContentLoaded", function () {
    // Initialize Swiper
    var swiper = new Swiper(".mySwiper", {
        slidesPerView: 3, // Show 3 images at a time
        spaceBetween: 5, // Reduced space between images
        loop: true, // Infinite looping
        navigation: {
            nextEl: ".swiper-button-next",
            prevEl: ".swiper-button-prev",
        },
        speed: 500, // Smooth transition speed
        slidesPerGroup: 1, // Move one image at a time
    });

    // Adjust heights of car elements
    let maxHeight = 0;
    document.querySelectorAll('.car').forEach(car => {
        maxHeight = Math.max(maxHeight, car.clientHeight);
    });
    document.querySelectorAll('.car').forEach(car => {
        car.style.height = maxHeight + "px";
    });
});
