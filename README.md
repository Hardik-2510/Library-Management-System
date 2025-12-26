# 🚗 Parking Slot Booking System

A web-based Parking Slot Booking System built using HTML, CSS, JavaScript, and Firebase.  
This project provides role-based access for Admins and Customers to manage and book parking slots.

---

## 📌 Project Overview

The Parking Slot Booking System helps manage parking spaces digitally.

- Admins can manage parking locations, slots, and view earnings.
- Customers can view available slots and book parking spaces.
- Firebase Authentication is used for login.
- Firestore is used to store user and parking data.

---

## 🛠️ Technologies Used

- HTML
- CSS
- JavaScript
- Firebase Authentication
- Firebase Firestore

---

## 👥 User Roles

### Admin
- Login as admin
- Access Admin Dashboard
- Manage parking locations
- Manage parking slots
- View earnings

### Customer
- Signup / Login as customer
- Access Customer Dashboard
- View available parking slots
- Book parking slots (basic)

---

## 📂 Project Structure

Parking-Slot-Booking-System/
│
├── CSS/
│   ├── index-css.css
│   ├── signup-css.css
│   ├── admin-dashboard.css
│
├── JS/
│   ├── firebase.js
│   ├── login.js
│   ├── signup.js
│   ├── script.js
│
├── Pages/
│   ├── login.html
│   ├── signup.html
│   ├── admin-dashboard.html
│   ├── customer-dashboard.html
│
├── Assets/
│   └── images/
│
├── index.html
└── README.md


---

## 🔐 Authentication Flow

1. User signs up or logs in
2. Firebase Authentication verifies credentials
3. User role is fetched from Firestore
4. User is redirected to Admin or Customer dashboard

---

## 🗃️ Firestore Database Structure

users
 └── userUID
      ├── name
      ├── email
      ├── role (admin / customer)
      └── createdAt

parking_locations
 └── autoID
      ├── locationName
      ├── city
      ├── totalSlots
      ├── availableSlots

---

## 🚀 How to Run the Project

1. Clone the repository
2. Open the project in VS Code
3. Create a Firebase project
4. Enable Email/Password Authentication
5. Create Firestore database
6. Update Firebase credentials in firebase.js
7. Open index.html using Live Server

---

## 🎯 Future Enhancements

- Slot booking with date & time
- Payment integration
- Real-time slot availability
- Booking history
- Admin analytics dashboard

---

## 📌 Project Status

- Authentication: Completed
- Role-based access: Implemented
- Slot booking: In progress

---

## 👨‍💻 Developed By

HackyBoys Team  
Students | Web Development Enthusiasts

---

## 📄 License

This project is created for educational purposes only.
