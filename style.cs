* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
}

body {
    font-family: "Inter", sans-serif;
    background: #05070b;
    color: #ffffff;
    line-height: 1.6;
}


/* HEADER */

.header {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 75px;

    display: flex;
    align-items: center;
    justify-content: space-between;

    padding: 0 7%;

    background: rgba(5, 7, 11, 0.90);
    backdrop-filter: blur(15px);

    border-bottom: 1px solid rgba(59, 130, 246, 0.15);

    z-index: 1000;
}

.logo {
    color: white;
    text-decoration: none;
    font-size: 20px;
    font-weight: 800;
    letter-spacing: 1px;
}

.logo span,
.footer-logo span {
    color: #3b82f6;
}

nav {
    display: flex;
    gap: 25px;
}

nav a {
    color: #cbd5e1;
    text-decoration: none;
    font-size: 14px;
    font-weight: 600;

    transition: 0.3s;
}

nav a:hover {
    color: #3b82f6;
}

.menu-btn {
    display: none;
    background: none;
    border: none;
    color: white;
    font-size: 28px;
}


/* HERO */

.hero {
    min-height: 100vh;

    display: flex;
    align-items: center;
    justify-content: space-between;

    gap: 50px;

    padding: 120px 8% 80px;

    background:
        radial-gradient(
            circle at 80% 40%,
            rgba(37, 99, 235, 0.20),
            transparent 35%
        );
}

.hero-content {
    max-width: 650px;
    animation: slideLeft 1s ease;
}

.small-title {
    color: #3b82f6;
    font-size: 14px;
    font-weight: 700;
    letter-spacing: 3px;
    margin-bottom: 15px;
}

.hero h1 {
    font-size: clamp(45px, 7vw, 85px);
    line-height: 1;
    margin-bottom: 25px;
}

.hero h1 span,
.section-title span,
.about-text span {
    color: #3b82f6;
}

.hero p {
    color: #94a3b8;
    max-width: 580px;
    margin-bottom: 30px;
}

.hero-buttons {
    display: flex;
    gap: 15px;
    flex-wrap: wrap;
}

.btn {
    padding: 13px 25px;
    border-radius: 8px;
    text-decoration: none;
    font-weight: 700;
    transition: 0.3s;
}

.primary {
    background: #2563eb;
    color: white;
}

.primary:hover {
    background: #3b82f6;
    transform: translateY(-3px);
}

.secondary {
    border: 1px solid #2563eb;
    color: white;
}

.secondary:hover {
    background: #2563eb;
}


/* PROFILE */

.profile-container {
    position: relative;
    width: min(400px, 80vw);
    height: min(400px, 80vw);

    display: flex;
    justify-content: center;
    align-items: center;

    animation: float 4s ease-in-out infinite;
}

.profile-container img {
    width: 85%;
    height: 85%;

    object-fit: cover;

    border-radius: 50%;

    border: 5px solid #2563eb;

    position: relative;
    z-index: 2;
}

.profile-glow {
    position: absolute;

    width: 100%;
    height: 100%;

    border-radius: 50%;

    background: #2563eb;

    filter: blur(70px);
    opacity: 0.25;
}


/* SECTIONS */

.section {
    padding: 110px 8%;
    background: #080b12;
}

.dark-section {
    background: #05070b;
}

.section-title {
    text-align: center;
    margin-bottom: 50px;
}

.section-title p {
    color: #3b82f6;
    font-size: 13px;
    font-weight: 700;
    letter-spacing: 3px;
}

.section-title h2 {
    font-size: clamp(35px, 5vw, 55px);
}


/* ABOUT */

.about-box {
    max-width: 1100px;
    margin: auto;

    display: grid;
    grid-template-columns: 350px 1fr;

    gap: 60px;
    align-items: center;
}

.about-image img {
    width: 100%;
    border-radius: 20px;

    border: 1px solid rgba(59, 130, 246, 0.4);
}

.about-text h3 {
    font-size: 30px;
    margin-bottom: 20px;
}

.about-text p {
    color: #94a3b8;
    margin-bottom: 15px;
}

.info-grid {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 15px;
    margin-top: 30px;
}

.info-grid div {
    background: #0d111a;
    padding: 15px;
    border-radius: 10px;
    border-left: 3px solid #2563eb;
}

.info-grid strong,
.info-grid span {
    display: block;
}

.info-grid strong {
    color: #3b82f6;
    font-size: 13px;
}

.info-grid span {
    color: white;
}


/* CATEGORY */

.category-box {
    max-width: 1100px;
    margin: 0 auto 30px;

    background: #0b1019;

    border: 1px solid rgba(59, 130, 246, 0.20);

    border-radius: 18px;

    padding: 30px;

    transition: 0.3s;
}

.category-box:hover {
    border-color: rgba(59, 130, 246, 0.55);

    transform: translateY(-4px);
}

.category-header {
    display: flex;
    align-items: center;
    justify-content: space-between;

    gap: 20px;
}

.category-header > div {
    display: flex;
    align-items: center;
    gap: 15px;
}

.category-header h3 {
    font-size: 25px;
}

.category-number {
    width: 45px;
    height: 45px;

    display: flex;
    align-items: center;
    justify-content: center;

    border-radius: 10px;

    background: #2563eb;

    font-size: 13px;
    font-weight: 800;
}

.upload-info {
    color: #64748b;
    font-size: 13px;
    margin: 20px 0;
}

.upload-button {
    display: inline-block;

    padding: 10px 18px;

    background: #2563eb;

    border-radius: 8px;

    cursor: pointer;

    font-size: 13px;
    font-weight: 700;

    transition: 0.3s;
}

.upload-button:hover {
    background: #3b82f6;
    transform: translateY(-2px);
}

.upload-button input {
    display: none;
}


/* FILE GRID */

.file-grid {
    display: grid;

    grid-template-columns:
        repeat(auto-fill, minmax(200px, 1fr));

    gap: 18px;

    margin-top: 20px;
}

.empty-message {
    grid-column: 1 / -1;

    padding: 35px;

    text-align: center;

    border: 1px dashed #334155;

    border-radius: 12px;

    color: #64748b;
}


/* FILE CARD */

.file-card {
    background: #111827;

    border-radius: 12px;

    overflow: hidden;

    border: 1px solid #1e293b;

    transition: 0.3s;
}

.file-card:hover {
    transform: translateY(-5px);

    border-color: #2563eb;

    box-shadow:
        0 15px 35px rgba(37, 99, 235, 0.15);
}

.file-preview {
    height: 150px;

    background: #070a10;

    display: flex;
    align-items: center;
    justify-content: center;

    overflow: hidden;
}

.file-preview img {
    width: 100%;
    height: 100%;

    object-fit: cover;
}

.file-icon {
    font-size: 45px;
}

.file-details {
    padding: 15px;
}

.file-name {
    font-size: 13px;
    font-weight: 600;

    white-space: nowrap;
    overflow: hidden;
    text-overflow: ellipsis;

    margin-bottom: 12px;
}

.file-actions {
    display: flex;
    gap: 7px;
}

.file-actions a,
.delete-btn {
    flex: 1;

    padding: 8px;

    text-align: center;

    border-radius: 6px;

    font-size: 11px;

    text-decoration: none;

    border: none;

    cursor: pointer;
}

.view-btn {
    background: #1e293b;
    color: white;
}

.download-btn {
    background: #2563eb;
    color: white;
}

.delete-btn {
    background: #7f1d1d;
    color: white;
}

.file-actions a:hover,
.delete-btn:hover {
    opacity: 0.8;
}


/* FOOTER */

footer {
    text-align: center;

    padding: 50px 20px;

    background: #030507;

    border-top: 1px solid #111827;
}

.footer-logo {
    font-size: 22px;
    font-weight: 800;
}

footer p {
    color: #64748b;
    margin-top: 8px;
}

.copyright {
    font-size: 12px;
}


/* ANIMATIONS */

@keyframes float {

    0%,
    100% {
        transform: translateY(0);
    }

    50% {
        transform: translateY(-15px);
    }
}

@keyframes slideLeft {

    from {
        opacity: 0;
        transform: translateX(-40px);
    }

    to {
        opacity: 1;
        transform: translateX(0);
    }
}


/* MOBILE */

@media (max-width: 850px) {

    .menu-btn {
        display: block;
    }

    nav {
        position: absolute;

        top: 75px;
        left: 0;

        width: 100%;

        display: none;
        flex-direction: column;

        padding: 20px;

        background: #080b12;

        border-bottom: 1px solid #1e293b;
    }

    nav.active {
        display: flex;
    }

    .hero {
        flex-direction: column-reverse;
        text-align: center;

        padding-top: 130px;
    }

    .hero-buttons {
        justify-content: center;
    }

    .about-box {
        grid-template-columns: 1fr;
    }

    .about-image {
        max-width: 350px;
        margin: auto;
    }

    .category-header {
        flex-direction: column;
        align-items: flex-start;
    }

}

@media (max-width: 500px) {

    .header {
        padding: 0 5%;
    }

    .section {
        padding: 80px 5%;
    }

    .category-box {
        padding: 20px;
    }

    .info-grid {
        grid-template-columns: 1fr;
    }

    .file-grid {
        grid-template-columns: 1fr;
    }

}