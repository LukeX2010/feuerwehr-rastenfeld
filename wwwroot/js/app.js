// FF Rastenfeld – JavaScript Helpers

// Ladeanimation ausblenden wenn Blazor fertig geladen ist
document.addEventListener('DOMContentLoaded', function () {
    setTimeout(function () {
        const loader = document.getElementById('app-loader');
        if (loader) {
            loader.style.opacity = '0';
            loader.style.transition = 'opacity 0.5s ease';
            setTimeout(() => loader.remove(), 600);
        }
    }, 800);
});

// Navbar beim Scrollen einfärben
window.addEventListener('scroll', function () {
    const navbar = document.getElementById('navbar');
    const scrollBtn = document.getElementById('scroll-to-top');
    if (navbar) {
        navbar.classList.toggle('scrolled', window.scrollY > 60);
    }
    if (scrollBtn) {
        scrollBtn.classList.toggle('visible', window.scrollY > 400);
    }
});

// Fade-in beim Scrollen (Intersection Observer)
function initScrollAnimations() {
    const observer = new IntersectionObserver(function (entries) {
        entries.forEach(function (entry) {
            if (entry.isIntersecting) {
                entry.target.classList.add('visible');
            }
        });
    }, { threshold: 0.1 });

    document.querySelectorAll('.feature-card, .news-card, .einsatz-card, .fahrzeug-card, .mitglied-card, .aufgabe-card, .timeline-item').forEach(function (el) {
        observer.observe(el);
    });
}

// Neuaufruf nach Blazor Navigation
window.blazorInitScrollAnim = initScrollAnimations;

// Initial
setTimeout(initScrollAnimations, 500);
