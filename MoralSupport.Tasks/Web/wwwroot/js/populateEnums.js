document.addEventListener("DOMContentLoaded", function () {
    const dropdown = document.getElementById("statusDropdown");

    if (!dropdown) return;

    const selectedStatus = dropdown.getAttribute("data-selected");

    fetch("/api/enums/task-status")
        .then(res => res.json())
        .then(data => {
            data.forEach(status => {
                const option = document.createElement("option");
                option.value = status.value;
                option.text = status.display;
                

                if (status.value === selectedStatus) {
                    option.selected = true;
                }
                dropdown.appendChild(option);
            });
        })
        .catch(err => console.error("Failed to load task statuses", err));
});
