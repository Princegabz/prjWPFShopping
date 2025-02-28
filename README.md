# WPF Shopping App

This is a simple WPF (Windows Presentation Foundation) application for managing a product inventory. It allows users to add, update, view, and delete products with the following details:

- Product ID
- Product Name
- Price
- Quantity

## Features

- **Add Product:** Capture product details and add them to the list.
- **View Products:** Display the list of all added products.
- **Edit Product:** Select and update product details.
- **Delete Product:** Remove a product from the list.
- **Input Validation:** Ensures only numbers are entered in numeric fields.

## Technologies Used

- C#
- WPF

## How to Use

1. Add a product by filling in the product details and clicking the "Add Product" button.
2. Refresh the product list using the "Refresh Data" button.
3. Edit a product by selecting it from the list and clicking the "Update Product" button.
4. Delete a product by selecting it and clicking the "Delete" button.

## Project Structure

- **MainWindow\.xaml.cs:** Handles the UI interactions and product management logic.
- **ProductData.cs:** Static class holding the product list.
- **Products.cs:** Defines the product properties and methods.

## Future Enhancements

- Implement data persistence (e.g., save to a database or file).
- Add error handling and more user-friendly messages.
- Improve UI design.

---

This project is a great starting point for learning WPF and C# application development.

