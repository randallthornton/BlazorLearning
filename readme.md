# Debugging

To get tailwindcss working with visual studio, we have to run the following command before we begin debugging.

```cmd
npx tailwindcss -i ./wwwroot/css/app.css -o ./wwwroot/css/app.min.css --watch --minify
```

This will watch the html files for the additional css classes and have tailwind rebuild the app.min.css file served via wwwroot.

I'm using a VS extension for giving me tailwind intellisense https://github.com/theron-wang/VS2022-Editor-Support-for-Tailwind-CSS/blob/main/Getting-Started.md