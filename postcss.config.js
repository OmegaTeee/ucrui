module.exports = {
    plugins: [
        require('postcss-import'),
        require('postcss-nested'),
        require('postcss-mixins'),
        require('postcss-preset-env')({
            'stage': false,
            'preserve': true,
            'autoprefixer': false,
            'nesting-rules': true,
            'custom-selectors': true,
            'custom-properties': true,
        }),
        require('postcss-color-converter')({
            preserveCustomProps: true,
            outputColorFormat: 'rgb',
        }),
        require('postcss-combine-duplicated-selectors')({
            removeDuplicatedProperties: true,
            removeDuplicatedSelectors: true,
            removeDuplicatedValues: true,
        }),
        require('postcss-discard-comments')({
            removeAll: true,
        }),
    ]
};