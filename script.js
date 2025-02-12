function fetchUsers() {
    const xhr = new XMLHttpRequest();
    
    xhr.open("GET", "https://jsonplaceholder.typicode.com/users", true);
    
    xhr.onload = function() {
        if (xhr.status === 200) {
            const users = JSON.parse(xhr.responseText);
            displayUsers(users);
        } else {
            console.error("Error fetching users");
        }
    };
    xhr.send();
}

function displayUsers(users) {
    const usersContainer = document.getElementById("usersContainer");
    usersContainer.innerHTML = ""; // Clear any existing content
    
    users.forEach(user => {
        const userDiv = document.createElement("div");
        userDiv.className = "user";
        userDiv.innerHTML = `
            <h2>${user.name}</h2>
            <p><strong>Email:</strong> ${user.email}</p>
            <p><strong>Address:</strong> ${user.address.street}, ${user.address.city}</p>
        `;
        usersContainer.appendChild(userDiv);
    });
}
