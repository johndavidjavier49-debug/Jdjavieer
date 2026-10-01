/* =========================================
   MOBILE NAVIGATION
========================================= */

const menuBtn = document.getElementById("menuBtn");
const navMenu = document.getElementById("navMenu");

menuBtn.addEventListener("click", () => {
    navMenu.classList.toggle("active");
});

document.querySelectorAll("nav a").forEach(link => {

    link.addEventListener("click", () => {
        navMenu.classList.remove("active");
    });

});


/* =========================================
   FILE STORAGE
========================================= */

const DB_NAME = "SMJobsPortfolio";
const STORE_NAME = "portfolioFiles";

let database;


/* OPEN DATABASE */

const request = indexedDB.open(DB_NAME, 1);


request.onupgradeneeded = function(event) {

    database = event.target.result;

    if (!database.objectStoreNames.contains(STORE_NAME)) {

        database.createObjectStore(STORE_NAME, {
            keyPath: "id",
            autoIncrement: true
        });

    }

};


request.onsuccess = function(event) {

    database = event.target.result;

    loadAllFiles();

};


request.onerror = function() {

    console.error("Unable to open file database.");

};


/* =========================================
   UPLOAD FILES
========================================= */

document.querySelectorAll(".fileInput").forEach(input => {

    input.addEventListener("change", function(event) {

        const category = this.dataset.category;

        const files = Array.from(event.target.files);

        files.forEach(file => {

            saveFile(file, category);

        });

        this.value = "";

    });

});


function saveFile(file, category) {

    if (!database) return;

    const transaction =
        database.transaction([STORE_NAME], "readwrite");

    const store =
        transaction.objectStore(STORE_NAME);

    const fileData = {

        name: file.name,

        type: file.type,

        category: category,

        file: file,

        date: new Date().toISOString()

    };

    store.add(fileData);

    transaction.oncomplete = function() {

        loadCategory(category);

    };

}


/* =========================================
   LOAD ALL FILES
========================================= */

function loadAllFiles() {

    const categories = [
        "quiz",
        "longquiz",
        "midterms",
        "finals",
        "activity",
        "project"
    ];

    categories.forEach(category => {

        loadCategory(category);

    });

}


/* =========================================
   LOAD CATEGORY
========================================= */

function loadCategory(category) {

    if (!database) return;

    const transaction =
        database.transaction([STORE_NAME], "readonly");

    const store =
        transaction.objectStore(STORE_NAME);

    const request =
        store.getAll();

    request.onsuccess = function() {

        const files = request.result.filter(
            file => file.category === category
        );

        displayFiles(category, files);

    };

}


/* =========================================
   DISPLAY FILES
========================================= */

function displayFiles(category, files) {

    const container =
        document.getElementById(category + "Files");

    if (!container) return;

    container.innerHTML = "";

    if (files.length === 0) {

        container.innerHTML = `
            <div class="empty-message">
                No files uploaded yet.
            </div>
        `;

        return;
    }


    files.forEach(item => {

        const url =
            URL.createObjectURL(item.file);

        const card =
            document.createElement("div");

        card.className = "file-card";


        let preview = "";


        /* IMAGE */

        if (item.type.startsWith("image/")) {

            preview = `
                <div class="file-preview">
                    <img
                        src="${url}"
                        alt="${escapeHTML(item.name)}"
                    >
                </div>
            `;

        }

        /* PDF */

        else if (item.type === "application/pdf") {

            preview = `
                <div class="file-preview">
                    <div class="file-icon">📄</div>
                </div>
            `;

        }

        /* OTHER FILE */

        else {

            preview = `
                <div class="file-preview">
                    <div class="file-icon">📁</div>
                </div>
            `;

        }


        card.innerHTML = `

            ${preview}

            <div class="file-details">

                <div class="file-name"
                     title="${escapeHTML(item.name)}">

                    ${escapeHTML(item.name)}

                </div>

                <div class="file-actions">

                    <a
                        href="${url}"
                        target="_blank"
                        class="view-btn"
                    >
                        View
                    </a>

                    <a
                        href="${url}"
                        download="${escapeHTML(item.name)}"
                        class="download-btn"
                    >
                        Download
                    </a>

                    <button
                        class="delete-btn"
                        onclick="deleteFile(${item.id}, '${category}')"
                    >
                        Delete
                    </button>

                </div>

            </div>

        `;

        container.appendChild(card);

    });

}


/* =========================================
   DELETE FILE
========================================= */

function deleteFile(id, category) {

    const confirmDelete =
        confirm("Are you sure you want to delete this file?");

    if (!confirmDelete) return;


    const transaction =
        database.transaction([STORE_NAME], "readwrite");

    const store =
        transaction.objectStore(STORE_NAME);

    store.delete(id);

    transaction.oncomplete = function() {

        loadCategory(category);

    };

}


/* =========================================
   SECURITY / HTML ESCAPE
========================================= */

function escapeHTML(text) {

    const div = document.createElement("div");

    div.textContent = text;

    return div.innerHTML;

}


/* =========================================
   PROFILE IMAGE
========================================= */

const profileImage =
    document.getElementById("profileImage");

if (profileImage) {

    const savedProfile =
        localStorage.getItem("smjobsProfileImage");

    if (savedProfile) {

        profileImage.src = savedProfile;

    }

}


/* =========================================
   OPTIONAL PROFILE IMAGE CHANGE
   Double-click your profile picture.
========================================= */

profileImage.addEventListener("dblclick", function() {

    const input =
        document.createElement("input");

    input.type = "file";

    input.accept = "image/*";

    input.click();


    input.addEventListener("change", function() {

        const file = this.files[0];

        if (!file) return;


        const reader = new FileReader();


        reader.onload = function(event) {

            profileImage.src =
                event.target.result;

            localStorage.setItem(
                "smjobsProfileImage",
                event.target.result
            );

        };


        reader.readAsDataURL(file);

    });

});