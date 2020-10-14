// using System;

// namespace csharp_learnin {
//   class Movie {
//     public string title;
//     public string director;
//     private string rating;
//     public Movie (string movieTitle, string movieDirector, string movieRating) {
//       title = movieTitle;
//       director = movieDirector;
//       Rating = movieRating; // essentially calling the Rating property and passing it in
//     }

//     public string Rating { // value is the value passed into property
//       get {  return rating; }
//       set {
//         if ( value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR" ) {
//           rating = value;
//         } else {
//           rating = "NR";
//         }
//       }
//     }
//   }
// }

// // getters setters make it more secure
// // control access of what people have access to in terms of data

// // 1. close off access to ratings attribute
// // 2., set to private - meaning only code in Movie class can access that attribute i.e. rating is a private attribute
// // 3. Create getters and settings for the rating attribute because it is private

// // define them using property basically like method but special to allow defining of getter and setter