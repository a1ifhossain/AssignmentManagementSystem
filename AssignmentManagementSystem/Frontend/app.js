const API_URL = "https://localhost:7071/api";

document
    .getElementById("loginForm")
    .addEventListener("submit", async function (event) {

        event.preventDefault();

        const email = document.getElementById("email").value;
        const password = document.getElementById("password").value;
        const message = document.getElementById("message");

        message.textContent = "Logging in...";

        try {
            const response = await fetch(`${API_URL}/Auth/login`, {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({
                    email: email,
                    password: password
                })
            });

            const data = await response.json();

            if (!response.ok) {
                message.textContent = data.message || "Invalid email or password.";
                return;
            }

            // Save login information
            localStorage.setItem("token", data.token);
            localStorage.setItem("user", JSON.stringify(data.user));

            message.textContent = "Login successful!";

            // Go to dashboard
            window.location.href = "dashboard.html";

        } catch (error) {
            console.error(error);
            message.textContent =
                "Cannot connect to the server. Make sure the API is running.";
        }
    });