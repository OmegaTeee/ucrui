module.exports = {
    plugins: [
        require('postcss-import')({
            syntax: 'scss',
        }),
        require('postcss-mixins')(),
        require('postcss-nested')(),
        require('postcss-color-converter')({
            outputColorFormat: 'rgb',
            alwaysAlpha: true,
        }),
        require('postcss-calc')(),
        require('postcss-preset-env')({
            stage: 3,
            autoprefixer: false,
            features: {
                'custom-properties': true, // Use CSS variables
                'nesting-rules': true, // Use nesting rules
                'custom-selectors': { preserve: true } // Preserve custom selectors
            }
        })
    ]
};