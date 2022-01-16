import ImageEditor from '@toast-ui/react-image-editor';
import 'tui-image-editor/dist/tui-image-editor.css';
import './App.css';
function App() {
  const myTheme = {
  };
  return (
    <div className="App">
      <ImageEditor
        includeUI={{
          loadImage: {
            path: 'img/sampleImage.jpg',
            name: 'SampleImage'
          },
          theme: myTheme,
          menu: ['filter', 'crop', 'rotate', 'text', 'flip'],
          initMenu: 'filter',
          uiSize: {
            height: '850px'
          },
          menuBarPosition: 'left'
        }}
        cssMaxHeight={800}
        cssMaxWidth={1000}
        selectionStyle={{
          cornerSize: 20,
          rotatingPointOffset: 70
        }}
        usageStatistics={true}
      >
      </ImageEditor>
    </div >
  );
}

export default App;